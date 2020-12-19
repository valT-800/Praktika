using System;
using System.Windows.Forms;
using Uzduotis.Backend.Models;
using Uzduotis.Frontend.Controllers.AdminControllers;
using Uzduotis.Frontend.Controllers.UserControllers;
using Uzduotis.Frontend.Forms.SystemForms;

namespace Uzduotis
{
    public partial class AdminForm : Form
    {
		private readonly UserProfileController profileController = new UserProfileController();
		private readonly AdminLecturersController adminLecturersController = new AdminLecturersController();
		public AdminForm()
		{
			InitializeComponent();
			adminUsernameLabel.Text = Global.Username;

		}

		private void ProfileButton_Click(object sender, EventArgs e)
		{
			adminHeaderLabel.Text = ProfileButton.Text;

			adminPanel.Controls.Clear();
			adminPanel.Controls.Add(profileController);
			profileController.Show();
		}

		private void LogOutButton_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}

        private void StudentGrupesButton_Click(object sender, EventArgs e)
        {
			AdminGrupesForm adminGrupesForm = new AdminGrupesForm();
			adminGrupesForm.Show();
			this.Visible = false;
		}

        private void LecturersButton_Click(object sender, EventArgs e)
        {
			adminHeaderLabel.Text = LecturersButton.Text;

			adminPanel.Controls.Clear();
			adminPanel.Controls.Add(adminLecturersController);
			adminLecturersController.Show();

		}
    }
}
