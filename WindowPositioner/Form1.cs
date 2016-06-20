using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowScrape.Types;

namespace WindowPositioner
{
    public partial class mainWindow : Form
    {

        public mainWindow()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            AddProfileForm addProfileDialog = new AddProfileForm();

            string newProfileName;

            if (addProfileDialog.ShowDialog(this) == DialogResult.OK)
            {
                newProfileName = addProfileDialog.GetProfileName();
                profilesComboBox.Items.Add(new Profile() {
                    ProfileName = newProfileName
                });
            }


            addProfileDialog.Dispose();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Profile selectedProfile = (Profile)profilesComboBox.Items[profilesComboBox.SelectedIndex];

            EditProfileForm editProfileDialog = new EditProfileForm(selectedProfile);
            
            if (editProfileDialog.ShowDialog(this) == DialogResult.OK)
            {

            }
            
        }
    }

    public class Profile
    {
        public List<ProgramProcess> ProgramProcesses = new List<ProgramProcess>();
        public string ProfileName { get; set; }

        public override string ToString()
        {
            return ProfileName;
        }
    }

    public class ProgramProcess {
        public IntPtr HWND { get; set; }
        public string ProcessName { get; set; }
    }
}
