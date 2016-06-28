using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowPositioner.Models;
using System.Windows.Forms;

namespace WindowPositioner
{
    public partial class SelectProcessForm : Form
    {
        public SelectProcessForm()
        {
            InitializeComponent();

            GetCurrentWindows();
        }

        public void GetCurrentWindows()
        {
            currentWindowsListBox.Items.Clear();

            List<Window> currentProcesses = WindowAccessor.GetInstalledPrograms();

            foreach(Window process in currentProcesses)
            {
                currentWindowsListBox.Items.Add(process);
            }
        }

        public Window GetSelectedProcess()
        {
            return (Window)currentWindowsListBox.Items[currentWindowsListBox.SelectedIndex];
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetCurrentWindows();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            List<Window> searchedWindows = new List<Window>();

            foreach(Window window in currentWindowsListBox.Items)
            {
                if (window.ProcessName.ToLower().Contains(searchText.ToLower()))
                {
                    searchedWindows.Add(window);
                }
            }

            currentWindowsListBox.Items.Clear();

            foreach (Window process in searchedWindows)
            {
                currentWindowsListBox.Items.Add(process);
            }
        }
    }
}
