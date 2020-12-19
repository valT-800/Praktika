using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uzduotis.Frontend.Controllers.LecturerControllers;

namespace Uzduotis.Frontend.Forms.SystemForms
{
    public partial class LecturerGradesForm : Form
    {
        private readonly LecturerGradesController lecturerGradesController = new LecturerGradesController();
        public LecturerGradesForm()
        {
            InitializeComponent();

            gradesPanel.Controls.Clear();
            gradesPanel.Controls.Add(lecturerGradesController);
            lecturerGradesController.Show();
        }
    }
}
