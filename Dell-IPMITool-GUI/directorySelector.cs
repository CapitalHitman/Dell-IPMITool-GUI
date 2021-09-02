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
            //Opens file selection dialog

            OpenFileDialog fileDlg = new OpenFileDialog();
            fileDlg.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";

            //If file selection dialog returns OK, writes (but does not yet save) the file path to an application setting ipmiPath
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

        private async void okButton_Click(object sender, EventArgs e)
        {
            String filePath = Properties.Settings.Default.ipmiPath;
            bool file = File.Exists(filePath);
            Program.log("File path exists?: " + file);
            if (filePath == null || filePath == "")
            {
                Program.errorPopup("Please select a file path.");
                return;
            }
            string versionOutput = await Program.commandExecuteAsync("-V");
            Program.log(versionOutput);
            if (file && filePath.Contains("ipmitool.exe") && versionOutput.Contains("ipmitool version 1.8.14.dell47"))
            {
                Program.log("File path has been evaluated as being valid and has been saved to persistent settings!");
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload(); 
                this.Hide();
                var Connector = new Connector();
                Connector.Closed += (s, args) => this.Close();
                Connector.Show();
                return;
            }
            else if (!file)
            {
                Program.errorPopup("The selected file does not exist! Please ensure that the file you selected is in a valid directory and is not access restricted.");
                return;
            }
            else if (!filePath.Contains("ipmitool.exe"))
            {
                Program.errorPopup("The selected file is not ipmitool.exe! Please select the correct EXE file.");
                return;
            }
            else if (!versionOutput.Contains("ipmitool version 1.8.14.dell47"))
            {
                Program.errorPopup("The installed version of Dell IPMITool is old! Please update to the latest version 1.8.14.dell47. Installed Version: " + versionOutput);
                return;
            }

        }

        private void directorySelector_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
