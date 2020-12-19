using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Uzduotis.Backend.Models;
using Uzduotis.Data;
using Uzduotis.Frontend.Controllers.AdminControllers;

namespace Uzduotis.Frontend.Forms.SystemForms
{
    public partial class AdminGrupesForm : Form
    {
		private readonly UserRepository repository;
		private readonly AdminAddGrupeController adminAddGrupeController = new AdminAddGrupeController();
		public AdminGrupesForm()
		{
			InitializeComponent();

			repository = new UserRepository();

			List<Grupe> grupesList = repository.GetGrupes();

			foreach (Grupe grupe in grupesList)
			{
				grupesComboBox.Items.Add(grupe.Title);
			}

		}
		private void ViewStudentsButton_Click(object sender, EventArgs e)
        {
			repository.SetGrupeId(grupesComboBox.Text);
			DisplayingStudentsInListView();
        }
		public void DisplayingStudentsInListView()
		{
			studentsListView.Items.Clear();
			try
			{
				var studentsList = repository.GetGrupeStudents(Global.GrupeID);
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
				AdminGradesForm adminGradesForm = new AdminGradesForm();
				adminGradesForm.Show();
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
				DeleteStudentButton.Enabled = true;
				ViewStudentGradesButton.Enabled = true;

			}
			else
			{
				DeleteStudentButton.Enabled = false;

				ViewStudentGradesButton.Enabled = false;
			}
			ListView.SelectedListViewItemCollection listView = this.studentsListView.SelectedItems;
			int userId = 0;
			foreach (ListViewItem item in listView)
			{
				userId += int.Parse(item.SubItems[4].Text);
			}
			Global.UserID = userId;
			
		}

        private void AddGrupeButton_Click(object sender, EventArgs e)
        {
			try
			{
				addGrupePanel.Controls.Clear();
				addGrupePanel.Controls.Add(adminAddGrupeController);
				adminAddGrupeController.Show();
				DisplayingStudentsInListView();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void DeleteGrupeButton_Click(object sender, EventArgs e)
        {
			DeleteGrupeButton.Enabled = false;
			try
			{
				repository.SetGrupeId(grupesComboBox.Text);
				repository.DeleteGrupe(Global.GrupeID);
				DisplayingStudentsInListView();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
			try
			{
				AdminAddStudentForm adminAddStudentForm = new AdminAddStudentForm();
				adminAddStudentForm.Show();

				DisplayingStudentsInListView();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
			DeleteStudentButton.Enabled = false;
			try
			{
				repository.DeleteStudent(Global.UserID);
				DisplayingStudentsInListView();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        
    }
}
