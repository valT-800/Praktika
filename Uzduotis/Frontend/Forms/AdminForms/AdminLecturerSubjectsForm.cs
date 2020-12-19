using System;
using System.Collections.Generic;
using Uzduotis.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Uzduotis.Frontend.Controllers.AdminControllers;
using Uzduotis.Repositories.ItemRepository;
using Uzduotis.Backend.Models;

namespace Uzduotis.Frontend.Forms.AdminForms
{
    public partial class AdminLecturerSubjectsForm : Form
    {
        private readonly ItemsRepository repository = new ItemsRepository();
        private readonly AdminLecturerSubjectsController adminLecturerSubjectsController = new AdminLecturerSubjectsController();
        public AdminLecturerSubjectsForm()
        {
            InitializeComponent();

            subjectsPanel.Controls.Clear();
            subjectsPanel.Controls.Add(adminLecturerSubjectsController);
            adminLecturerSubjectsController.Show();
        }

        
        
    }
}
