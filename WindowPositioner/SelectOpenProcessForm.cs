using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowPositioner.Models;

namespace WindowPositioner
{
    public partial class SelectOpenProcessForm : Form
    {
        public SelectOpenProcessForm()
        {
            InitializeComponent();

            List<Window> openWindows = WindowAccessor.GetOpenWindows();

            foreach(Window window in openWindows)
            {
                openProcesses.Items.Add(window);
            }
            
        }

        public Window GetSelectedWindow()
        {
            return (Window)openProcesses.Items[openProcesses.SelectedIndex];
        }

    }
}
