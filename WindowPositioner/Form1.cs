using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowPositioner.Models;

namespace WindowPositioner
{
    public partial class mainWindow : Form
    {

        public mainWindow()
        {
            InitializeComponent();
            LoadSavedData();

            string a = WindowAccessor.GetApplicationPath("notepad.exe");
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            AddProfileForm addProfileDialog = new AddProfileForm();

            string newProfileName;

            if (addProfileDialog.ShowDialog(this) == DialogResult.OK)
            {
                newProfileName = addProfileDialog.GetProfileName();
                profilesComboBox.Items.Add(new Profile()
                {
                    ProfileName = newProfileName
                });

                Save();
            }


            addProfileDialog.Dispose();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            profilesComboBox.Items.RemoveAt(profilesComboBox.SelectedIndex);
            profilesComboBox.ResetText();

            Save();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Profile selectedProfile = (Profile)profilesComboBox.Items[profilesComboBox.SelectedIndex];

            EditProfileForm editProfileDialog = new EditProfileForm(selectedProfile);

            if (editProfileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Save();
            }

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Profile selectedProfile = (Profile)profilesComboBox.Items[profilesComboBox.SelectedIndex];

            WindowAccessor.OpenPrograms(selectedProfile.Windows);
        }


        public void LoadSavedData()
        {
            try
            {
                string readText = File.ReadAllText("save.json");
                List<Profile> profiles = new JavaScriptSerializer().Deserialize<List<Profile>>(readText);
                profilesComboBox.Items.AddRange(profiles.ToArray());

            }
            catch (ArgumentException){ }
            catch (FileNotFoundException) { }

        }

        public void Save()
        {
            string createText = new JavaScriptSerializer().Serialize(profilesComboBox.Items);
            File.WriteAllText("save.json", createText);
        }

        
    }
}
