using System;
using System.Windows.Forms;
using Uzduotis.Backend.Models;
using Uzduotis.Frontend.Controllers.StudentControllers;
using Uzduotis.Frontend.Controllers.UserControllers;
using Uzduotis.Frontend.Forms.SystemForms;

namespace Uzduotis
{
    public partial class StudentForm : Form
    {
        private readonly UserProfileController profileController = new UserProfileController();

        public StudentForm()
        {
            InitializeComponent();
            studentNameLabel.Text = Global.Username;
        }
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            studentHeaderLabel.Text = ProfileButton.Text;

            studentPanel.Controls.Clear();
            studentPanel.Controls.Add(profileController);
            profileController.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void SubjectsButton_Click(object sender, EventArgs e)
        {
            StudentSubjectsForm studentSubjectsForm = new StudentSubjectsForm();
            studentSubjectsForm.Show();
        }
    }
}
