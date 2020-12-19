using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uzduotis.Data;

namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    public partial class AdminAddGrupeController : UserControl
    {
        private readonly UserRepository repository = new UserRepository();
        public AdminAddGrupeController()
        {
            InitializeComponent();
        }

        private void AddGrupeButton_Click(object sender, EventArgs e)
        {
            try
            {
                repository.AddGrupe(grupeTitleTextBox.Text);
            }
            catch
            {
                throw new Exception("Grupe was not added");
            }
        }
    }
}
