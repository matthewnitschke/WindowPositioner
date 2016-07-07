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

        private void button1_Click(object sender, EventArgs e)
        {
            SelectOpenProcessForm selectOpenProcessDialog = new SelectOpenProcessForm();

            if (selectOpenProcessDialog.ShowDialog(this) == DialogResult.OK)
            {
                Window selectedWindow = selectOpenProcessDialog.GetSelectedWindow();

                urlTextBox.Text = selectedWindow.ExecutablePath;
                programNameTextBox.Text = selectedWindow.ProcessName;

                windowX.Text = selectedWindow.WindowBounds.X.ToString();
                windowY.Text = selectedWindow.WindowBounds.Y.ToString();
                windowWidth.Text = selectedWindow.WindowBounds.Width.ToString();
                windowHeight.Text = selectedWindow.WindowBounds.Height.ToString();

            }


            selectOpenProcessDialog.Dispose();
        }
    }
}
