using System;
using System.Windows.Forms;
using Uzduotis.Data;

namespace Uzduotis.Frontend.Forms.AdminForms
{
    public partial class AdminAddLecturerForm : Form
    {
        private readonly UserRepository repository = new UserRepository();

        public AdminAddLecturerForm()
        {
            InitializeComponent();
        }

        private void AddLecturerButton_Click(object sender, EventArgs e)
        {
            try
            {
                repository.AddLecturer(nameTextBox.Text, surnameTextBox.Text, birthDateTimePicker.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
