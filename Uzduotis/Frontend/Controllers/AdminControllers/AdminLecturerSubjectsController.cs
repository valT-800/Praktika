using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Uzduotis.Backend.Models;
using Uzduotis.Repositories.ItemRepository;

namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    public partial class AdminLecturerSubjectsController : UserControl
    {
        private readonly ItemsRepository repository = new ItemsRepository();
        private readonly AdminAddSubjectController adminAddSubjectController = new AdminAddSubjectController();
        public AdminLecturerSubjectsController()
        {
            InitializeComponent();
            subjectsListView.Items.Clear();

        }
        private void AdminLecturerSubjectsController_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayingSubjectsInListView();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }
        private void DisplayingSubjectsInListView()
        {
            subjectsListView.Items.Clear();
            try
            {
                List<Subject> subjectsList = repository.GetLecturerSubjects(Global.UserID);
                foreach (Subject subject in subjectsList)
                {
                    ListViewItem subjects = new ListViewItem(subject.ID.ToString());
                    subjects.SubItems.Add(subject.Title);
                    subjects.SubItems.Add(subject.GrupeID.ToString());

                    subjectsListView.Items.Add(subjects);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void subjectsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectsListView.SelectedItems.Count > 0)
            {
                DeleteSubjectButton.Enabled = true;
            }
            else
            {
                DeleteSubjectButton.Enabled = false;
            }
            ListView.SelectedListViewItemCollection listView = this.subjectsListView.SelectedItems;
            int subjectId = 0;
            foreach (ListViewItem item in listView)
            {
                subjectId += int.Parse(item.SubItems[0].Text);
            }
            Global.SubjectID = subjectId;
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                newSubjectPanel.Controls.Clear();
                newSubjectPanel.Controls.Add(adminAddSubjectController);
                adminAddSubjectController.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayingSubjectsInListView();
        }

        private void DeleteSubjectButton_Click(object sender, EventArgs e)
        {
            DeleteSubjectButton.Enabled = false;

            try
            {
                repository.DeleteSubject(Global.SubjectID);
                DisplayingSubjectsInListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
