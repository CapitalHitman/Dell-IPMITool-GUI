using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dell_IPMITool_GUI.Popups
{
    public partial class errorPopup : Form
    {
        public errorPopup()
        {
            InitializeComponent();
        }

        private void invalidTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectionInvalidPopup_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
