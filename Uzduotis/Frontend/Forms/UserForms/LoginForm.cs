using System;
using System.Windows.Forms;
using Uzduotis.Data;

namespace Uzduotis
{
	public partial class LoginForm : Form
	{
		private readonly UserRepository repository = new UserRepository();

		public LoginForm()
		{
			InitializeComponent();
			repository.InsertAdmin();
		}
		private void LoginButton_Click(object sender, EventArgs e)
		{
			try
			{
				repository.Login(usernameLabel.Text, passwordLabel.Text);
				if (studentRadioButton.Checked)
					repository.StudentLogin();
				if(lecturerRadioButton.Checked)
					repository.LecturerLogin();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}
	}
}
