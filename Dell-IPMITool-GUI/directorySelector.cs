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
                pathBox.Text = fileDlg.FileName;
                Debug.WriteLine(fileDlg.FileName);
                
                Properties.Settings.Default.ipmiPath = fileDlg.FileName;

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
            Debug.WriteLine(directory);
            if (directory &&  folderPath.Contains("ipmitool.exe")) {
              Debug.WriteLine("Path Valid!");
            }
            else if (!directory)
            {
                selectionInvalidPopup errorPopup = new selectionInvalidPopup();
                errorPopup.Show();
            }
            else if (!folderPath.Contains("ipmitool.exe"))
            {
                selectionInvalidPopup errorPopup = new selectionInvalidPopup();
                errorPopup.Show();
            }
            Debug.WriteLine(folderPath);                
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

        }
    }
}
