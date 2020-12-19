using System;
using System.Windows.Forms;
using Uzduotis.Backend.Models;
using Uzduotis.Backend.Users;
using Uzduotis.Data;

namespace Uzduotis.Frontend.Controllers.UserControllers
{
    public partial class UserProfileController : UserControl
	{
		private readonly UserPasswordChangeController passwordChange = new UserPasswordChangeController();
		private readonly UserRepository repository = new UserRepository();
		
		public UserProfileController()
        {
            InitializeComponent();

			var users = repository.GetUser(Global.ID);
			foreach(User user in users)
            {
				nameLabel.Text = user.Name;
				surnameLabel.Text = user.Surname;
				usernameLabel.Text = user.Username;
				birthDateLabel.Text = user.BirthDate.ToString();
			}
		}

		private void UploadPictureButton_Click(object sender, EventArgs e)
        {
			ProfilePictureLoad();
		}
		private void ProfilePictureLoad()
		{
			try
			{
				OpenFileDialog fileDialog = new OpenFileDialog
				{
					Title = "Select image file",
					DefaultExt = ".jpg",
					Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*"
				};

				DialogResult result = fileDialog.ShowDialog();
				if (result.Equals(DialogResult.OK))
				{
					profilePictureBox.Load(fileDialog.FileName);
				}

			}
			catch (Exception)
			{
				MessageBox.Show("Wrong file format!");
			}
		}

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
			changePasswordPanel.Controls.Clear();
			changePasswordPanel.Controls.Add(passwordChange);
			passwordChange.Show();
		}
    }
}
