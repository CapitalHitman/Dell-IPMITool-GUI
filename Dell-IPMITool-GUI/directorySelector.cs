using Dell_IPMITool_GUI.Popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
                String path = fileDlg.FileName;
                pathBox.Text = path;
                Program.log("Selected file path: " + path);

                Properties.Settings.Default.ipmiPath = path;

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            String folderPath = Properties.Settings.Default.ipmiPath;
            bool directory = File.Exists(folderPath);
            Program.log("File path exists?: " + directory);
            if (directory && folderPath.Contains("ipmitool.exe"))
            {
                Program.log("File path has been evaluated as being valid and has been saved to persistent settings!");
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
            else if (!directory)
            {
                Program.errorPopup("The selected file does not exist!");
            }
            else if (!folderPath.Contains("ipmitool.exe"))
            {
                Program.log("Selected file is not the ipmitool.exe");
            }

        }
    }
}
