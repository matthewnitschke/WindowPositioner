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

            List<ProgramProcess> currentProcesses = WindowAccessor.GetOpenWindows();

            foreach(ProgramProcess process in currentProcesses)
            {
                currentWindowsListBox.Items.Add(process);
            }
        }

        public ProgramProcess GetSelectedProcess()
        {
            return (ProgramProcess)currentWindowsListBox.Items[currentWindowsListBox.SelectedIndex];
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetCurrentWindows();
        }
    }
}
