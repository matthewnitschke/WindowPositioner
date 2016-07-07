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
    public partial class AddProcessForm : Form
    {
        public AddProcessForm()
        {
            InitializeComponent();
        }

        public Window GetSelectedWindow()
        {
            // Convert.ToInt32(windowX.Text), Convert.ToInt32(windowY.Text)
            return new Window()
            {
                ExecutablePath = urlTextBox.Text,
                ProcessName = programNameTextBox.Text,
                WindowBounds = new Bounds()
                {
                    X = Convert.ToInt32(windowX.Text),
                    Y = Convert.ToInt32(windowY.Text),
                    Width = Convert.ToInt32(windowWidth.Text),
                    Height = Convert.ToInt32(windowHeight.Text)
                }
            };
        }
    }
}
