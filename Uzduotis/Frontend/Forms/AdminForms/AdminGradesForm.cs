using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Uzduotis.Backend.Models;
using Uzduotis.Frontend.Controllers.AdminControllers;
using Uzduotis.Frontend.Controllers.LecturerControllers;
using Uzduotis.Repositories.ItemRepository;


namespace Uzduotis.Frontend.Forms.SystemForms
{
    public partial class AdminGradesForm : Form
    {
		private readonly AdminGradesController adminGradesController = new AdminGradesController();
		private readonly ItemsRepository repository;
		public AdminGradesForm()
		{
			InitializeComponent();

			repository = new ItemsRepository();

			List<Subject> subjectsList = repository.GetGrupeSubjects(Global.GrupeID);

			foreach (Subject subject in subjectsList)
			{
				subjectsComboBox.Items.Add(subject.Title);
			}
			
		}
		private void ViewGradesButton_Click(object sender, EventArgs e)
        {
			repository.SetSubjectId(subjectsComboBox.Text);
			gradesPanel.Controls.Clear();
			gradesPanel.Controls.Add(adminGradesController);
			adminGradesController.Show();
        }
		

        
    }
}
