using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uzduotis.Repositories.ItemRepository;
using Uzduotis.Backend.Models;

namespace Uzduotis.Frontend.Controllers.LecturerControllers
{
    public partial class LecturerAddGradeController : UserControl
    {
        private readonly ItemsRepository repository = new ItemsRepository();
        public LecturerAddGradeController()
        {
            InitializeComponent();
        }

        private void AddGradeButton_Click(object sender, EventArgs e)
        {
            try
            {
                repository.AddGrade(int.Parse(gradeValueTextBox.Text), workTitleTextBox.Text, Global.UserID, Global.SubjectID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
