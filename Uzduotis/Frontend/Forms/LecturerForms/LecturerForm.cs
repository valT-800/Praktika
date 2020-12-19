using System;
using System.Windows.Forms;
using Uzduotis.Backend.Models;
using Uzduotis.Frontend.Controllers.UserControllers;
using Uzduotis.Frontend.Forms.SystemForms;

namespace Uzduotis
{
    public partial class LecturerForm : Form
    {
		private readonly UserProfileController profileController = new UserProfileController();
		public LecturerForm()
		{
			InitializeComponent();
			lecturerUsernameLabel.Text = Global.Username;

		}

		private void ProfileButton_Click(object sender, EventArgs e)
		{
			lecturerHeaderLabel.Text = ProfileButton.Text;

			lecturerPanel.Controls.Clear();
			lecturerPanel.Controls.Add(profileController);
			profileController.Show();
		}

		private void LogOutButton_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}

        private void SubjectsButton_Click(object sender, EventArgs e)
        {
			LecturerSubjectsForm lecturerSubjectsForm = new LecturerSubjectsForm();
			lecturerSubjectsForm.Show();
		}
    }
}
