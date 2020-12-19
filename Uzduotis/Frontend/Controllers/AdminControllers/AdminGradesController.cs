using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Uzduotis.Backend.Models;
using Uzduotis.Frontend.Controllers.AdminControllers;
using Uzduotis.Repositories.ItemRepository;

namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    public partial class AdminGradesController : UserControl
    {	
		private readonly ItemsRepository repository = new ItemsRepository();

		private readonly AdminChangeGradeController adminChangeGradeController = new AdminChangeGradeController();
		public AdminGradesController()
		{
			InitializeComponent();
			gradesListView.Items.Clear();

		}
		
		private void AdminGradesController_Load(object sender, EventArgs e)
		{
			gradesListView.Items.Clear();
			try
			{
				DisplayingGradesInListView();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
		}
		private void DisplayingGradesInListView()
		{
			gradesListView.Items.Clear();
			try
			{
				List<Grade> gradesList = repository.GetStudentGrades(Global.SubjectID);
				foreach (Grade grade in gradesList)
				{
					ListViewItem grades = new ListViewItem(grade.WorkTitle);
					grades.SubItems.Add(grade.GradeValue.ToString());

					gradesListView.Items.Add(grades);
				}

			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void gradesListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (gradesListView.SelectedItems.Count > 0)
			{
				ChangeGradeButton.Enabled = true;
				DeleteGradeButton.Enabled = true;
			}
			else
			{
				ChangeGradeButton.Enabled = false;
				DeleteGradeButton.Enabled = false;
			}
			ListView.SelectedListViewItemCollection listView = this.gradesListView.SelectedItems;
			var workTitle = " ";
			foreach (ListViewItem item in listView)
			{
				workTitle += item.SubItems[0].Text;
			}
			Global.WorkTitle = workTitle;
			
		}

		private void ChangeGradeButton_Click(object sender, EventArgs e)
		{
			ChangeGradeButton.Enabled = false;
			try
			{
				newGradePanel.Controls.Clear();
				newGradePanel.Controls.Add(adminChangeGradeController);
				adminChangeGradeController.Show();

				DisplayingGradesInListView();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void DeleteGradeButton_Click(object sender, EventArgs e)
		{
			DeleteGradeButton.Enabled = false;
			try
			{
				repository.DeleteStudentGrade(Global.WorkTitle, Global.UserID);
				DisplayingGradesInListView();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
