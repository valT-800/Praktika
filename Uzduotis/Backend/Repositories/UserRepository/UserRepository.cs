using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Collections.Generic;
using Uzduotis.Backend.Models;
using Uzduotis.Repositories.ItemRepository;
using Uzduotis.Backend.Users;

namespace Uzduotis.Data
{
	class UserRepository
	{
		private readonly SqlConnection connection;
		private readonly ItemsRepository repository =new ItemsRepository();


		public UserRepository()
		{
			connection = new SqlConnection(@"Server=LAPTOP-1VDJU9IG;Database=academic;Integrated Security=True");
		}
		public void Login(string username, string password)
		{
			try
			{
				var query = "select * from users where username = @username and password = @password";
				var selectUserId = "select id from users where username = @username";

				SqlCommand commandQuery = new SqlCommand(query, connection);
				SqlCommand commandUserId = new SqlCommand(selectUserId, connection);

				commandQuery.Parameters.AddWithValue("@username", username);
				commandQuery.Parameters.AddWithValue("@password", password);
				commandUserId.Parameters.AddWithValue("@username", username);
				
				connection.Open();

				SqlDataAdapter adapter = new SqlDataAdapter(commandQuery);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				if (dataTable.Rows.Count > 0)
				{
					var id = (int)commandUserId.ExecuteScalar();
					Global.ID = id;
					Global.Username = username;
					Global.UserID = Global.ID;

					for (int i = 0; i < dataTable.Rows.Count; i++)
					{

						if (dataTable.Rows[i]["username"].ToString() == "vali")
						{
							connection.Close();
							AdminForm adminForm = new AdminForm();
							adminForm.ShowDialog();
						}
						else
						{
							connection.Close();
						}
					}
				}
				else
				{
					connection.Close();
					throw new Exception("Login Failed");
				}
			}
			catch (Exception exc)
			{
				throw new Exception(exc.Message);
			}
		}
		public void LecturerLogin()
        {
			try
			{
				var selectLecturer = "SELECT * FROM lecturers WHERE userId=@userId";

				SqlCommand command = new SqlCommand(selectLecturer, connection);

				command.Parameters.AddWithValue("@userId", Global.ID);

				connection.Open();

				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				if (dataTable.Rows.Count > 0)
				{
					connection.Close();

					LecturerForm lecturerForm = new LecturerForm();
					lecturerForm.ShowDialog();
				}
				else
                {
					connection.Close();
					throw new Exception("Login failed");
                }					
			}
			catch (Exception exc)
			{
				throw new Exception(exc.Message);
			}
		}
		public void StudentLogin()
		{
			try
			{
				var selectStudent = "SELECT * FROM students WHERE userId=@userId";
				var selectGrupeId = "SELECT grupeId FROM students WHERE userId=@userId";

				SqlCommand command = new SqlCommand(selectStudent, connection);
				SqlCommand commandGrupeId = new SqlCommand(selectGrupeId, connection);

				command.Parameters.AddWithValue("@userId", Global.ID);
				commandGrupeId.Parameters.AddWithValue("@userId", Global.ID);

				connection.Open();

				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				if (dataTable.Rows.Count > 0)
				{
					var grupeId = (int)commandGrupeId.ExecuteScalar();
					Global.GrupeID = grupeId;

					connection.Close();

					StudentForm studentForm = new StudentForm();
					studentForm.ShowDialog();
				}
				else
					throw new Exception("Login failed");
			}
			catch (Exception exc)
			{
				throw new Exception(exc.Message);
			}
		}
		public void UserPasswordChange(string passwordMatch, string newPassword)
		{
			var passwordMatchQuery = "select * from users where username = @username and password = @password";
		
			SqlCommand command = new SqlCommand(passwordMatchQuery, connection);
			
			command.Parameters.AddWithValue("@username", Global.Username);
			command.Parameters.AddWithValue("@password", passwordMatch);

			connection.Open();
			SqlDataReader dataReader = command.ExecuteReader();

			if(dataReader.Read())
			{	
				connection.Close();			
				if (string.IsNullOrEmpty(newPassword))
				{
					MessageBox.Show("Password textbox is empty");
				}
				else
				{
					var passwordChangeQuery = "update users set password = @password where username = @username";
					connection.Open();
					SqlCommand changePasswordCommand = new SqlCommand(passwordChangeQuery, connection);

					changePasswordCommand.Parameters.AddWithValue("@password", newPassword);
					changePasswordCommand.Parameters.AddWithValue("@username", Global.Username);

					SqlDataAdapter dataAdapter = new SqlDataAdapter(changePasswordCommand);
					DataTable dataTable = new DataTable();
					dataAdapter.Fill(dataTable);

					changePasswordCommand.ExecuteNonQuery();
					connection.Close();
					MessageBox.Show("Password Changed Successfully");
				}
				
			}
			else
			{
				connection.Close();
				MessageBox.Show("Invalid Password Match");
			}
		}
		public void InsertAdmin()
		{
			var selectAdminQuery = "select * from users where username = @username";

			SqlCommand commandSelectionQuery = new SqlCommand(selectAdminQuery, connection);

			commandSelectionQuery.Parameters.AddWithValue("@username", "vali");

			SqlDataAdapter dataAdapter = new SqlDataAdapter(commandSelectionQuery);

			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

			if (dataTable.Rows.Count.Equals(0))
			{
				var insertAdminQuery = "insert into users(name,surname,username,password,birthDate)" +
				"values (@name, @surname, @username, @password, @birthDate)";

				SqlCommand commandInsertionQuery = new SqlCommand(insertAdminQuery, connection);

				commandInsertionQuery.Parameters.AddWithValue("@name", "Valentina");
				commandInsertionQuery.Parameters.AddWithValue("@surname", "Oleskeviciute");
				commandInsertionQuery.Parameters.AddWithValue("@username", "vali");
				commandInsertionQuery.Parameters.AddWithValue("@password", "oles");
				commandInsertionQuery.Parameters.AddWithValue("@birthDate", "1999-10-18");

				connection.Open();
				commandInsertionQuery.ExecuteNonQuery();
				connection.Close();
			}
		}	
		public List<Grupe> GetGrupes()
		{
			List<Grupe> grupesList = new List<Grupe>();

			try
			{
				var selectGrupe = "SELECT id, title FROM grupes";
				SqlCommand command = new SqlCommand(selectGrupe, connection);

				connection.Open();
				SqlDataReader dataReader = command.ExecuteReader();

				while (dataReader.Read())
				{
					var id = int.Parse(dataReader["id"].ToString());
					var title = dataReader["title"].ToString();

					grupesList.Add(new Grupe(id, title));
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			foreach (Grupe grupes in grupesList)
			{
				grupes.SetStudents(GetGrupeStudents(grupes.ID));
				grupes.SetSubjects(repository.GetGrupeSubjects(grupes.ID));
			}

			return grupesList;
		}
		public List<Student> GetGrupeStudents(int grupeId)
		{
			List<Student> studentsList = new List<Student>();

			try
			{
				var selectStudent = "SELECT * FROM students WHERE grupeId = @grupeId";

				SqlCommand commandStudent = new SqlCommand(selectStudent, connection);

				commandStudent.Parameters.AddWithValue("@grupeId", grupeId);
				
				connection.Open();

				SqlDataAdapter adapter = new SqlDataAdapter(commandStudent);
				DataTable table = new DataTable();
				adapter.Fill(table);

				while (table.Rows.Count > 0)
				{
					var userId = int.Parse(table.Rows[0]["userId"].ToString());

					connection.Close();
					studentsList = GetStudentUsers(studentsList, userId);

					table.Rows.RemoveAt(0);
					connection.Open();

				}								
				connection.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return studentsList;
		}
		public List<Student> GetStudentUsers(List<Student> studentsList, int id)
        {
            try
            {
				var selectUser = "SELECT * FROM users WHERE id = @id";

				SqlCommand commandUser = new SqlCommand(selectUser, connection);

				connection.Open();

				commandUser.Parameters.AddWithValue("@id", id);

				SqlDataReader dataReader = commandUser.ExecuteReader();

				if (dataReader.Read())
				{
					var name = dataReader["name"].ToString();
					var surname = dataReader["surname"].ToString();
					var username = dataReader["username"].ToString();
					var password = dataReader["password"].ToString();
					var birthDate = DateTime.Parse(dataReader["birthDate"].ToString());

					studentsList.Add(new Student(id, name, surname, username, password, birthDate));
				}
				connection.Close();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return studentsList;

		}
		public List<Lecturer> GetLecturerUsers(List<Lecturer> lecturersList, int id)
		{
			try
			{
				var selectUser = "SELECT * FROM users WHERE id = @id";

				SqlCommand commandUser = new SqlCommand(selectUser, connection);

				connection.Open();

				commandUser.Parameters.AddWithValue("@id", id);

				SqlDataReader dataReader = commandUser.ExecuteReader();

				if (dataReader.Read())
				{
					var name = dataReader["name"].ToString();
					var surname = dataReader["surname"].ToString();
					var username = dataReader["username"].ToString();
					var password = dataReader["password"].ToString();
					var birthDate = DateTime.Parse(dataReader["birthDate"].ToString());

					lecturersList.Add(new Lecturer(id, name, surname, username, password, birthDate));
				}

				connection.Close();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return lecturersList;

		}
		public List<Student> GetSubjectGrupeStudents(int subjectId)
		{
			List<Student> studentsList = new List<Student>();

			try
			{
				var selectGrupe = "SELECT grupeId FROM subjects WHERE id = @id";

				SqlCommand commandGrupe = new SqlCommand(selectGrupe, connection);

				commandGrupe.Parameters.AddWithValue("@id", subjectId);
				
				connection.Open();
				
				var grupeId = (int)commandGrupe.ExecuteScalar();

				var selectStudent = "SELECT * FROM students WHERE grupeId = @grupeId";

				SqlCommand commandStudent = new SqlCommand(selectStudent, connection);

				commandStudent.Parameters.AddWithValue("@grupeId", grupeId);
								
				SqlDataAdapter adapter = new SqlDataAdapter(commandStudent);
				DataTable table = new DataTable();
				adapter.Fill(table);

				while (table.Rows.Count > 0)
				{
					var userId = int.Parse(table.Rows[0]["userId"].ToString());

					connection.Close();

					studentsList = GetStudentUsers(studentsList, userId);

					table.Rows.RemoveAt(0);
					connection.Open();

				}
				connection.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return studentsList;
		}		
		public List<Lecturer> GetLecturers()
		{
			List<Lecturer> lecturersList = new List<Lecturer>();

			try
			{
				var selectLecturer = "SELECT * FROM lecturers";

				SqlCommand commandLecturer = new SqlCommand(selectLecturer, connection);

				connection.Open();

				SqlDataAdapter adapter = new SqlDataAdapter(commandLecturer);
				DataTable table = new DataTable();
				adapter.Fill(table);

				while (table.Rows.Count > 0)
				{
					var userId = int.Parse(table.Rows[0]["userId"].ToString());

					connection.Close();
					lecturersList = GetLecturerUsers(lecturersList, userId);

					table.Rows.RemoveAt(0);
					connection.Open();

				}
				connection.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			foreach (Lecturer lecturers in lecturersList)
			{
				lecturers.SetSubjects(repository.GetLecturerSubjects(lecturers.ID));
			}

			return lecturersList;
		}
		public List<User> GetUser(int id)
        {
			List<User> usersList = new List<User>();
			try
			{
				var selectUser = "SELECT * FROM users WHERE id = @id";

				SqlCommand commandUser = new SqlCommand(selectUser, connection);

				connection.Open();

				commandUser.Parameters.AddWithValue("@id", id);

				SqlDataReader dataReader = commandUser.ExecuteReader();

				if (dataReader.Read())
				{
					var name = dataReader["name"].ToString();
					var surname = dataReader["surname"].ToString();
					var username = dataReader["username"].ToString();
					var password = dataReader["password"].ToString();
					var birthDate = DateTime.Parse(dataReader["birthDate"].ToString());

					usersList.Add(new User(id, name, surname, username, password, birthDate));
				}

				connection.Close();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return usersList;
		}
		public void AddGrupe(string title)
        {
			try
			{
				connection.Open();

				var insertGrupe = "INSERT INTO grupes (id, title) VALUES (@id, @title)";

				SqlCommand commandInsertGrupe = new SqlCommand(insertGrupe, connection);

				commandInsertGrupe.Parameters.AddWithValue("@title", title);

				commandInsertGrupe.ExecuteNonQuery();

				connection.Close();

				MessageBox.Show("Grupe Added Successfully");
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}
		public void DeleteGrupe(int id)
		{
			try
			{
				connection.Open();

				var deleteGrupe = "DELETE FROM grupes WHERE id = @id";

				SqlCommand commandDeleteGrupe = new SqlCommand(deleteGrupe, connection);

				commandDeleteGrupe.Parameters.AddWithValue("@id", id);

				commandDeleteGrupe.ExecuteNonQuery();
				
				connection.Close();

				List<Student> students = GetGrupeStudents(id);

				foreach(Student student in students)
                {
					DeleteStudent(student.ID);
				}
									
				
			}
			catch (SystemException ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}
		public void DeleteStudent(int userId)
        {
			var deleteStudent = "DELETE FROM students WHERE userId = @userId";

			SqlCommand commandDeleteStudent = new SqlCommand(deleteStudent, connection);
			
			commandDeleteStudent.Parameters.AddWithValue("@userId", userId);

			connection.Open();
			commandDeleteStudent.ExecuteNonQuery();
			
			connection.Close();

			var grades = repository.GetStudentGrades(userId);
			
			foreach(Grade grade in grades)
            {
				repository.DeleteGrade(grade.ID);
            }
			
			
			DeleteUser(userId);

		}
		public void DeleteLecturer(int userId)
		{
			var deleteLecturer = "DELETE FROM lecturers WHERE userId = @userId";

			SqlCommand commandDeleteLecturer = new SqlCommand(deleteLecturer, connection);

			commandDeleteLecturer.Parameters.AddWithValue("@userId", userId);

			connection.Open();

			commandDeleteLecturer.ExecuteNonQuery();
			
			connection.Close();

			var subjects = repository.GetLecturerSubjects(userId);
			
			

			foreach(Subject subject in subjects)
            {
				repository.DeleteSubject(subject.ID);
			}
			
			DeleteUser(userId);

		}
		public void DeleteUser(int id)
		{
			try
			{
				connection.Open();
				
				var deleteUser = "DELETE FROM users WHERE id = @id";

				SqlCommand commandDeleteUser = new SqlCommand(deleteUser, connection);

				commandDeleteUser.Parameters.AddWithValue("@id", id);

				commandDeleteUser.ExecuteNonQuery();

				connection.Close();
			}
			catch (SystemException ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}
		public void AddStudent(string name, string surname, DateTime birthDate)
		{
			try
			{
				var userId = AddUser(name, surname, birthDate);
				
				connection.Open();

				var insertStudent = "INSERT INTO students (userId, grupeId) VALUES (@userId, @grupeId)";

				SqlCommand commandInsertStudent = new SqlCommand(insertStudent, connection);

				commandInsertStudent.Parameters.AddWithValue("@userId", userId);
				commandInsertStudent.Parameters.AddWithValue("@grupeId", Global.GrupeID);

				commandInsertStudent.ExecuteNonQuery();

				connection.Close();

				MessageBox.Show("Student Added Successfully");

			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}
		public void AddLecturer(string name, string surname, DateTime birthDate)
		{
			try
			{
				var userId = AddUser(name, surname, birthDate);
		
				var insertLecturer = "INSERT INTO lecturers (userId) VALUES (@userId)";

				SqlCommand commandInsertLecturer = new SqlCommand(insertLecturer, connection);

				commandInsertLecturer.Parameters.AddWithValue("@userId", userId);
				
				connection.Open();

				commandInsertLecturer.ExecuteNonQuery();
							
				connection.Close();

				MessageBox.Show("Lecturer Added Successfully");

			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}
		public int AddUser(string name, string surname, DateTime birthDate)
        {
			int id = 0;
			try
			{
				connection.Open();

				var insertUser = "INSERT INTO users (name, surname, username, password, birthDate) VALUES (@name, @surname, @username, @password, @birthDate)";
				var selectUserId = "SELECT id FROM users WHERE username=@username";

				SqlCommand commandInsertUser = new SqlCommand(insertUser, connection);
				SqlCommand commandUserId = new SqlCommand(selectUserId, connection);

				commandInsertUser.Parameters.AddWithValue("@name", name);
				commandInsertUser.Parameters.AddWithValue("@surname", surname);
				commandInsertUser.Parameters.AddWithValue("@username", name);
				commandInsertUser.Parameters.AddWithValue("@password", surname);
				commandInsertUser.Parameters.AddWithValue("@birthDate", birthDate);

				commandInsertUser.ExecuteNonQuery();

				commandUserId.Parameters.AddWithValue("@username", name);

				id = (int)commandUserId.ExecuteScalar();

				connection.Close();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));

			}
			return id;
			

		}
		public void SetGrupeId(string title)
		{
			try
			{
				var select = "SELECT id FROM grupes WHERE title = @title";

				SqlCommand command = new SqlCommand(select, connection);

				command.Parameters.AddWithValue("@title", title);

				connection.Open();

				var id = (int)command.ExecuteScalar();
				Global.GrupeID = id;

				connection.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}
	}
}
