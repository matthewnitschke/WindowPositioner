using System;
using WindowPositioner.Models;
using System.Windows.Forms;

namespace WindowPositioner
{
    public partial class EditProfileForm : Form
    {
        Profile EditingProfile;

        public EditProfileForm(Profile profile)
        {
            EditingProfile = profile;

            InitializeComponent();

            InitializeData();
        }

        private void InitializeData()
        {
            programProcessesListBox.Items.Clear();

            foreach(Window process in EditingProfile.Windows)
            {
                programProcessesListBox.Items.Add(process);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SelectProcessForm selectProcessDialog = new SelectProcessForm();

            if (selectProcessDialog.ShowDialog(this) == DialogResult.OK)
            {
                EditingProfile.Windows.Add(selectProcessDialog.GetSelectedWindow());
                
            }

            InitializeData();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            EditingProfile.Windows.RemoveAt(programProcessesListBox.SelectedIndex);
            programProcessesListBox.Items.RemoveAt(programProcessesListBox.SelectedIndex);
            programProcessesListBox.ClearSelected();

        }
    }
}
