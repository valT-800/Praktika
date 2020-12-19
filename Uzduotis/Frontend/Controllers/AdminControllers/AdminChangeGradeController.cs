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

namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    public partial class AdminChangeGradeController : UserControl
    {
        private readonly ItemsRepository repository = new ItemsRepository();
        public AdminChangeGradeController()
        {
            InitializeComponent();
        }

        private void ChangeGradeButton_Click(object sender, EventArgs e)
        {
            try
            {
                repository.ChangeGrade(Global.UserID, Global.WorkTitle, int.Parse(newValueTextBox.Text));
            }
            catch
            {
                throw new Exception("Grade was not changed");
            }
        }
    }
}
