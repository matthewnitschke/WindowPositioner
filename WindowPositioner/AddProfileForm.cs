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
    public partial class AddProfileForm : Form
    {
        public AddProfileForm()
        {
            InitializeComponent();
        }

        public string GetProfileName()
        {
            return profileNameTextBox.Text;
        }
    }
}
