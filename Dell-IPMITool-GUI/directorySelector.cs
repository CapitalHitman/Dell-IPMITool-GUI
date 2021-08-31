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

namespace Dell_IPMITool_GUI
{
    public partial class directorySelector : Form
    {
        public directorySelector()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDlg = new OpenFileDialog();

            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = fileDlg.FileName;            
                Debug.WriteLine(fileDlg.FileName);
                
                Properties.Settings.Default.ipmiPath = fileDlg.FileName;
                Properties.Settings.Default.Save();
            }
        }
    }
}
