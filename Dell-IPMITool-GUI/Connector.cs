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
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace Dell_IPMITool_GUI
{
    public partial class Connector : Form
    {
        public static int tabNumber = 0;
        private string quickConnectIPString;
        private string quickConnectUsername;
        private string quickConnectPassword;
        public static ArrayList tabGUID = new ArrayList();

        [DllImport("user32")]
        private static extern bool HideCaret(IntPtr hWnd);

        public Connector()
        {


            
            InitializeComponent();
        }

        private void Connector_Load(object sender, EventArgs e)
        {

            bool tabsDirExists = Directory.Exists(Application.StartupPath + @"\tabs\");
            if (!tabsDirExists)
            {
                Directory.CreateDirectory(Application.StartupPath + @"\tabs\");
            }
            string[] GUIDList = Directory.GetFiles(Application.StartupPath + @"\tabs\");
            foreach (string tabGUID in GUIDList)
            {
                string GUIDPath = Path.Combine(Path.GetFileNameWithoutExtension(tabGUID));
                Program.log(GUIDPath);
                Guid processedGUID = Guid.Parse(GUIDPath);
                Program.log(GUIDPath);
                NewServerPage(processedGUID);
            }
            NewServerPage();
            quickConnectTextbox.GotFocus += (s1, e1) => { HideCaret(quickConnectTextbox.Handle); };
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Temporarily store inputs once entered.
        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {
                    quickConnectIPString = ipQuickConnectTextBox.Text;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
                    quickConnectUsername = usernameQuickConnectTextBox.Text;
        }
        
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
                    quickConnectPassword = passwordQuickConnectTextBox.Text;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            validationErrorBox.Text = "";
            bool validIP = Program.validateIP(quickConnectIPString);
            if (!validIP)
            {
                validationErrorBox.AppendText("IP Address is invalid. \n");
            }

            //Username input validation
            if (String.IsNullOrEmpty(quickConnectUsername) || String.IsNullOrWhiteSpace(quickConnectUsername))
            {
                validationErrorBox.AppendText("Username cannot be empty. \n");
            }

            //Password input validation
            if (String.IsNullOrEmpty(quickConnectPassword) || String.IsNullOrWhiteSpace(quickConnectPassword))
            {
                validationErrorBox.AppendText("Password cannot be empty. \n");
            }


            if (rememberLogin.Checked && validIP && !String.IsNullOrWhiteSpace(quickConnectPassword) && !String.IsNullOrEmpty(quickConnectPassword) && !String.IsNullOrEmpty(quickConnectUsername) && !String.IsNullOrWhiteSpace(quickConnectUsername))
            {
                Program.log("IP, Username, and Password were all evaluated as valid entries and have been saved");
                Properties.Settings.Default.ipmiip = quickConnectIPString;
                Properties.Settings.Default.username = quickConnectUsername;
                Properties.Settings.Default.password = quickConnectPassword;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
        }

        private void newServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewServerPage();
        }

        private void Connector_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        //Create tabs
        public void NewServerPage(Guid GUID)
        {
            tabPageUserControl userControl = new tabPageUserControl(GUID);
            TabPage page = new TabPage("Server #" + tabNumber);
            userControl.Dock = DockStyle.Fill;
            page.Controls.Add(userControl);
            this.tabControl1.Controls.Add(page);
            this.Update();
        }
        public void NewServerPage()
        {
            tabPageUserControl userControl = new tabPageUserControl();
            TabPage page = new TabPage("Server #" + tabNumber);
            userControl.Dock = DockStyle.Fill;
            page.Controls.Add(userControl);
            this.tabControl1.Controls.Add(page);
            this.Update();
        }
    }
}
