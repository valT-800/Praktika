using System;
using System.Windows.Forms;
using Uzduotis.Data;
using Uzduotis.Backend.Models;
using System.Data.SqlClient;
using Uzduotis.Frontend.Forms.AdminForms;

namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    public partial class AdminLecturersController : UserControl
    {
		private readonly UserRepository repository = new UserRepository();
        public AdminLecturersController()
        {
            InitializeComponent();
			lecturersListView.Items.Clear();
        }
		private void AdminLecturersController_Load(object sender, EventArgs e)
        {
			try
			{
				DisplayingLecturersInListView();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
		}
		public void DisplayingLecturersInListView()
		{
			lecturersListView.Items.Clear();

			try
			{
				var lecturersList = repository.GetLecturers();
				foreach (Lecturer lecturer in lecturersList)
				{
					ListViewItem lecturers = new ListViewItem(lecturer.Name);
					lecturers.SubItems.Add(lecturer.Surname);
					lecturers.SubItems.Add(lecturer.Username);
					lecturers.SubItems.Add(lecturer.BirthDate.ToString());
					lecturers.SubItems.Add(lecturer.ID.ToString());

					lecturersListView.Items.Add(lecturers);
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void lecturersListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lecturersListView.SelectedItems.Count > 0)
			{
				LecturerSubjectsButton.Enabled = true;
				DeleteLecturerButton.Enabled = true;
			}
			else
			{
				LecturerSubjectsButton.Enabled = false;
				DeleteLecturerButton.Enabled = false;
			}
			ListView.SelectedListViewItemCollection listView = this.lecturersListView.SelectedItems;
			var userId = 0;
			foreach (ListViewItem item in listView)
			{
				userId += int.Parse(item.SubItems[4].Text);
				Global.UserID = userId;
			}
			
		}

		private void AddLecturerButton_Click(object sender, EventArgs e)
        {
			try
			{
				AdminAddLecturerForm adminAddLecturerForm = new AdminAddLecturerForm();
				adminAddLecturerForm.Show();
				
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			DisplayingLecturersInListView();
        }

        private void LecturerSubjectsButton_Click(object sender, EventArgs e)
        {
			LecturerSubjectsButton.Enabled = false;

			try
			{
				AdminLecturerSubjectsForm adminLecturerSubjectsForm = new AdminLecturerSubjectsForm();
				adminLecturerSubjectsForm.Show();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

        private void DeleteLecturerButton_Click(object sender, EventArgs e)
        {
			DeleteLecturerButton.Enabled = false;

			try
			{
				repository.DeleteLecturer(Global.UserID);
				
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			DisplayingLecturersInListView();
		}

        
    }
}
