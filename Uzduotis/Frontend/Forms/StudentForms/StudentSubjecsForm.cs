using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Uzduotis.Backend.Models;
using Uzduotis.Frontend.Controllers.StudentControllers;
using Uzduotis.Repositories.ItemRepository;

namespace Uzduotis.Frontend.Forms.SystemForms
{
    public partial class StudentSubjectsForm : Form
    {
		private readonly StudentGradesController studentGradesController = new StudentGradesController();
		private readonly ItemsRepository repository = new ItemsRepository();
		public StudentSubjectsForm()
		{
			InitializeComponent();
						
				List<Subject> subjectsList = repository.GetGrupeSubjects(Global.GrupeID);

				foreach (Subject subject in subjectsList)
				{
					subjectsComboBox.Items.Add(subject.Title);
				}
			}

        private void ViewGradesButton_Click(object sender, EventArgs e)
        {
			repository.SetSubjectId(subjectsComboBox.Text);
			studentGradesPanel.Controls.Clear();
			studentGradesPanel.Controls.Add(studentGradesController);
			studentGradesController.Show();
		}

    }
}
