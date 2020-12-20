using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows;
using Uzduotis.Backend.Models;

namespace Uzduotis.Repositories.ItemRepository
{
	class ItemsRepository
	{
		private readonly SqlConnection connection;

		public ItemsRepository()
		{
			connection = new SqlConnection(@"Server=LAPTOP-1VDJU9IG;Database=academic;Integrated Security=True");
		}
		public List<Subject> GetGrupeSubjects(int grupeId)
		{
			List <Subject> subjectsList = new List<Subject>();
			try
			{
				var selectSubject = "SELECT id, title FROM subjects WHERE grupeId = @grupeId";

				SqlCommand command = new SqlCommand(selectSubject, connection);

				command.Parameters.AddWithValue("@grupeId", grupeId);

				connection.Open();

				SqlDataReader dataReader = command.ExecuteReader();

				while (dataReader.Read())
				{
					var id = int.Parse(dataReader["id"].ToString());
					var title = dataReader["title"].ToString();

					subjectsList.Add(new Subject(id, title, grupeId));
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return subjectsList;
		}
		public List<Subject> GetLecturerSubjects(int userId)
		{
			List<Subject> subjectsList = new List<Subject>();
			try
			{
				var selectSubject = "SELECT id, title, grupeId FROM subjects WHERE lecturerId = @lecturerId";

				SqlCommand command = new SqlCommand(selectSubject, connection);

				command.Parameters.AddWithValue("@lecturerId", userId);

				connection.Open();

				SqlDataReader dataReader = command.ExecuteReader();

				while (dataReader.Read())
				{
					var id = int.Parse(dataReader["id"].ToString());
					var title = dataReader["title"].ToString();
					var grupeId = int.Parse(dataReader["grupeId"].ToString());


					subjectsList.Add(new Subject(id, title, grupeId));
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return subjectsList;
		}
		public List<Grade> GetStudentGrades(int subjectId)
		{

			List<Grade> gradesList = new List<Grade>();
			try
			{
				var selectGrade = "SELECT id, workTitle, gradeValue FROM grades WHERE studentId = @studentId and subjectId = @subjectId";

				SqlCommand command = new SqlCommand(selectGrade, connection);

				command.Parameters.AddWithValue("@studentId", Global.UserID);
				command.Parameters.AddWithValue("@subjectId", subjectId);

				connection.Open();

				SqlDataReader dataReader = command.ExecuteReader();

				while (dataReader.Read())
				{
					var id = int.Parse(dataReader["id"].ToString());
					var workTitle = dataReader["workTitle"].ToString();
					var gradeValue = int.Parse(dataReader["gradeValue"].ToString());
					
					gradesList.Add(new Grade(workTitle, gradeValue, id));
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return gradesList;
		}
		public List<Grade> GetSubjectGrades(int subjectId)
		{

			List<Grade> gradesList = new List<Grade>();
			try
			{
				var selectGrade = "SELECT id, workTitle, gradeValue FROM grades WHERE subjectId = @subjectId";

				SqlCommand command = new SqlCommand(selectGrade, connection);

				command.Parameters.AddWithValue("@subjectId", subjectId);

				connection.Open();

				SqlDataReader dataReader = command.ExecuteReader();

				while (dataReader.Read())
				{
					var id = int.Parse(dataReader["id"].ToString());
					var workTitle = dataReader["workTitle"].ToString();
					var gradeValue = int.Parse(dataReader["gradeValue"].ToString());

					gradesList.Add(new Grade(workTitle, gradeValue, id));
				}
				connection.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return gradesList;
		}
		public void DeleteSubject(int subjectId)
        {
			try
			{
				connection.Open();

				var deleteSubject = "DELETE FROM subjects WHERE id = @id";

				SqlCommand commandDeleteSubject = new SqlCommand(deleteSubject, connection);

				commandDeleteSubject.Parameters.AddWithValue("@id", subjectId);

				commandDeleteSubject.ExecuteNonQuery();
				
				connection.Close();

				var grades = GetSubjectGrades(subjectId);
				
				
				
				foreach(Grade grade in grades)
                {
					DeleteGrade(grade.ID);
                }
				
				
			}
			catch (SystemException ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}
		public void DeleteStudentGrade(string workTitle, int studentId)
		{
			try
			{
				connection.Open();

				var deleteGrade = "DELETE FROM grades WHERE workTitle = @workTitle and studentId = @studentId";

				SqlCommand commandDeleteGrade = new SqlCommand(deleteGrade, connection);

				commandDeleteGrade.Parameters.AddWithValue("@workTitle", workTitle);
				commandDeleteGrade.Parameters.AddWithValue("@studentId", studentId);

				commandDeleteGrade.ExecuteNonQuery();

				connection.Close();
			}
			catch (SystemException ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}
		public void DeleteGrade(int id)
		{
			try
			{
				connection.Open();

				var deleteGrade = "DELETE FROM grades WHERE id = @id";

				SqlCommand commandDeleteGrade = new SqlCommand(deleteGrade, connection);

				commandDeleteGrade.Parameters.AddWithValue("@id", id);

				commandDeleteGrade.ExecuteNonQuery();

				connection.Close();
			}
			catch (SystemException ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}
		public void AddSubject(string title, int lecturerId, string grupeTitle)
		{
			try
			{
				connection.Open();

				var insertSubject = "INSERT INTO subjects (title, grupeId, lecturerId) VALUES (@title, @grupeId, @lecturerId)";
				var selectGrupeId = "SELECT id FROM grupes WHERE title=@title";

				SqlCommand commandInsertSubject = new SqlCommand(insertSubject, connection);
				SqlCommand commandSelectGrupeId = new SqlCommand(selectGrupeId, connection);

				commandSelectGrupeId.Parameters.AddWithValue("@title", grupeTitle);

				var grupeId = (int)commandSelectGrupeId.ExecuteScalar();

				commandInsertSubject.Parameters.AddWithValue("@title", title);
				commandInsertSubject.Parameters.AddWithValue("@grupeId", grupeId);
				commandInsertSubject.Parameters.AddWithValue("@lecturerId", lecturerId);

				commandInsertSubject.ExecuteNonQuery();

				connection.Close();

				MessageBox.Show("Subject Added Successfully");

			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}
		public void AddGrade(int gradeValue, string workTitle, int userId, int subjectId)
		{
			try
			{
				connection.Open();

				var insertGrade = "INSERT INTO grades (gradeValue, workTitle, studentId, subjectId) VALUES (@gradeValue, @workTitle, @studentId, @subjectId)";

				SqlCommand commandInsertGrade = new SqlCommand(insertGrade, connection);

				commandInsertGrade.Parameters.AddWithValue("@gradeValue", gradeValue);
				commandInsertGrade.Parameters.AddWithValue("@workTitle", workTitle);
				commandInsertGrade.Parameters.AddWithValue("@studentId", userId);
				commandInsertGrade.Parameters.AddWithValue("@subjectId", subjectId);

				commandInsertGrade.ExecuteNonQuery();

				connection.Close();
				MessageBox.Show("Grade Added Successfully");

			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
			}
		}
		public void ChangeGrade(int studentId, string workTitle, int newGrade)
		{
			if (newGrade.Equals(null))
			{
				MessageBox.Show("Grade textbox is empty");
			}
			else
			{
				var gradeChangeQuery = "update grades set gradeValue = @gradeValue where workTitle = @workTitle and studentId = @studentId and subjectId = @subjectId";
				connection.Open();
				SqlCommand commandChangeGrade = new SqlCommand(gradeChangeQuery, connection);

				commandChangeGrade.Parameters.AddWithValue("@gradeValue", newGrade);
				commandChangeGrade.Parameters.AddWithValue("@workTitle", workTitle);
				commandChangeGrade.Parameters.AddWithValue("@subjectId", Global.SubjectID);
				commandChangeGrade.Parameters.AddWithValue("@studentId", studentId);

				SqlDataAdapter dataAdapter = new SqlDataAdapter(commandChangeGrade);
				DataTable dataTable = new DataTable();
				dataAdapter.Fill(dataTable);

				commandChangeGrade.ExecuteNonQuery();
				connection.Close();

				MessageBox.Show("Grade Changed Successfully");
			}
		}
		public void SetSubjectId(string title)
		{
			try
			{
				var select = "SELECT id FROM subjects WHERE title = @title";

				SqlCommand command = new SqlCommand(select, connection);

				command.Parameters.AddWithValue("@title", title);

				connection.Open();

				var id = (int)command.ExecuteScalar();
				Global.SubjectID = id;

				connection.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}
		
	}
}
