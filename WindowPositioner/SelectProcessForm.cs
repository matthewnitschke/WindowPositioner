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
        }

        public Window GetSelectedWindow()
        {
            return new Window()
            {
                ExecutablePath = urlTextBox.Text,
                ProcessName = programNameTextBox.Text
            };
        }
    }
}
