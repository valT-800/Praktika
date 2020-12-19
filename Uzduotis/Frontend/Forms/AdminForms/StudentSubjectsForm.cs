using System.Windows.Forms;
using Uzduotis.Frontend.Controllers.StudentControllers;
using Uzduotis.Frontend.Controllers.UserControllers;

namespace Uzduotis.Frontend.Forms.SystemForms
{
    public partial class StudentSubjectsForm : Form
    {
		private readonly StudentGradesListController studentGradesListController = new StudentGradesListController();
		private readonly StudentSubjectsController studentSubjectsController = new StudentSubjectsController();
		public StudentSubjectsForm()
		{
			InitializeComponent();

			subjectsPanel.Controls.Clear();
			subjectsPanel.Controls.Add(studentSubjectsController);
			studentSubjectsController.Show();

			subjectsPanel.Controls.Clear();
			studentGradesPanel.Controls.Add(studentGradesListController);
			studentGradesListController.Show();
		}
    }
}
