using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Uzduotis.Backend.Models;
using Uzduotis.Repositories.ItemRepository;

namespace Uzduotis.Frontend.Controllers.StudentControllers
{
	public partial class StudentGradesController : UserControl
	{
		private readonly ItemsRepository repository = new ItemsRepository();
		public StudentGradesController()
		{
			InitializeComponent();
			gradesListView.Items.Clear();

		}
		private void StudentGradesController_Load(object sender, EventArgs e)
		{
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
	}
}
