using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Uzduotis.Data;
using Uzduotis.Backend.Models;
using Uzduotis.Repositories.ItemRepository;

namespace Uzduotis.Frontend.Controllers.AdminControllers
{
    public partial class AdminAddSubjectController : UserControl
    {
		private readonly UserRepository repository;
		private readonly ItemsRepository itemsRepository = new ItemsRepository();

		public AdminAddSubjectController()
        {
            InitializeComponent();

			repository = new UserRepository();

			List<Grupe> grupesList = repository.GetGrupes();

			foreach (Grupe grupe in grupesList)
			{
				grupesComboBox.Items.Add(grupe.Title);
			}
		}

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
			try
			{
				itemsRepository.AddSubject(subjectTitleTextBox.Text, Global.UserID, grupesComboBox.Text);
			}
			catch
			{
				throw new Exception("Subject was not added");
			}
		}

    }
}
