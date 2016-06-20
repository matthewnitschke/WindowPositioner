using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach(ProgramProcess process in EditingProfile.ProgramProcesses)
            {
                programProcessesListBox.Items.Add(process);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SelectProcessForm selectProcessDialog = new SelectProcessForm();

            if (selectProcessDialog.ShowDialog(this) == DialogResult.OK)
            {
                programProcessesListBox.Items.Add(selectProcessDialog.GetSelectedProcess());
            }
        }
    }
}
