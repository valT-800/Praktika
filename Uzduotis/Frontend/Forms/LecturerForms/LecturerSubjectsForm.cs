using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Uzduotis.Backend.Models;
using Uzduotis.Data;
using Uzduotis.Repositories.ItemRepository;

namespace Uzduotis.Frontend.Forms.SystemForms
{
    public partial class LecturerSubjectsForm : Form
    {
		private readonly ItemsRepository repository;
		private readonly UserRepository userRepository = new UserRepository();
		public LecturerSubjectsForm()
		{
			InitializeComponent();

			repository = new ItemsRepository();

			List<Subject> subjectsList = repository.GetLecturerSubjects(Global.ID);

			foreach (Subject subject in subjectsList)
			{
				subjectsComboBox.Items.Add(subject.Title);
			}

		}
		private void ViewStudentsButton_Click(object sender, EventArgs e)
        {
			repository.SetSubjectId(subjectsComboBox.Text);
			DisplayingStudentsInListView();
		}
		public void DisplayingStudentsInListView()
		{
			studentsListView.Items.Clear();
			try
			{
				var studentsList = userRepository.GetSubjectGrupeStudents(Global.SubjectID);
				foreach (Student student in studentsList)
				{
					ListViewItem students = new ListViewItem(student.Name);
					students.SubItems.Add(student.Surname);
					students.SubItems.Add(student.Username);
					students.SubItems.Add(student.BirthDate.ToString());
					students.SubItems.Add(student.ID.ToString());

					studentsListView.Items.Add(students);
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void ViewGradesButton_Click(object sender, EventArgs e)
		{
			try
			{
				LecturerGradesForm lecturerGradesForm = new LecturerGradesForm();
				lecturerGradesForm.Show();
				ViewStudentGradesButton.Enabled = false;
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        private void studentsListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (studentsListView.SelectedItems.Count > 0)
			{
				ViewStudentGradesButton.Enabled = true;

			}
			else
			{
				ViewStudentGradesButton.Enabled = false;
			}
			ListView.SelectedListViewItemCollection listView = this.studentsListView.SelectedItems;
			int userId = 0;
			foreach(ListViewItem item in listView)
            {
				userId += int.Parse(item.SubItems[4].Text);
			}
			Global.UserID = userId;

		}

        
    }
}
