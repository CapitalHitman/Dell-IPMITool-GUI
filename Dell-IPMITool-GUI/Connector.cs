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
using System.Text.Json;
using System.Text.Json.Serialization;
using FormSerialisation;
using System.Xml;

namespace Dell_IPMITool_GUI
{
    public partial class Connector : Form
    {
        private string quickConnectIPString;
        private string quickConnectUsername;
        private string quickConnectPassword;
        public static List<TabPageUserControl> tabInstances = new List<TabPageUserControl>();
        public static ArrayList assignedGUIDS = new ArrayList();

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
            
            if (Directory.GetDirectories(Application.StartupPath + @"\tabs\").Length == 0 && Directory.GetFiles(Application.StartupPath + @"\tabs\").Length == 0)
            {
                NewServerTab();
            }
            else
            {
                string[] GUIDList = Directory.GetFiles(Application.StartupPath + @"tabs\", "*.xml").Select(Path.GetFileNameWithoutExtension).Select(p => p.Substring(0)).ToArray();
                foreach(string guid in GUIDList)
                {
                    Program.log("Parsed GUID: " + guid);
                    NewServerTab(guid);
                    assignedGUIDS.Add(guid);
                }
            }
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
            NewServerTab();
        }

        private void Connector_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (TabPageUserControl tabs in tabInstances)
            {
                if (assignedGUIDS.Contains(tabs.localGUID))
                {
                    FormSerialisor.Serialise(tabs, Application.StartupPath + @"tabs\" + tabs.localGUID + ".xml");
                    xmlAddTabIndex(tabs.tabIndex, Application.StartupPath + @"tabs\" + tabs.localGUID + ".xml");
                    Program.log(Application.StartupPath + @"tabs\" + tabs.localGUID + ".xml");
                    Program.log("Saving Tab: " + tabs.localGUID);
                }
                else
                {
                    Guid newGUID = Guid.NewGuid();
                    Program.log(Application.StartupPath + @"tabs\" + newGUID + ".xml");
                    FormSerialisor.Serialise(tabs, Application.StartupPath + @"tabs\" + newGUID + ".xml");
                    Program.log("Saving new tab: " + newGUID);
                }
            }
        }

        //Create tabs
        public void NewServerTab()
        {
            TabPageUserControl tabUserControl = new TabPageUserControl();
            int tabCount = tabInstances.Count + 1;
            TabPage page = new TabPage("Server #" + tabCount);
            tabInstances.Add(tabUserControl);
            tabUserControl.Dock = DockStyle.Fill;
            page.Controls.Add(tabUserControl);
            this.tabControl1.Controls.Add(page);
            this.Update();
        }

        public void NewServerTab(string guid)
        {
            int tabCount = tabInstances.Count + 1;
            TabPageUserControl tabUserControl = new TabPageUserControl(guid, tabCount.ToString());
            TabPage page = new TabPage("Server #" + tabCount);
            tabInstances.Add(tabUserControl);
            tabUserControl.Dock = DockStyle.Fill;
            page.Controls.Add(tabUserControl);
            this.tabControl1.Controls.Add(page);
            this.Update();
        }

        public void xmlAddTabIndex(String tabIndex, String xmlPath)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlElement tabIndexElement = xmlDoc.CreateElement("tabIndex");
            tabIndexElement.InnerText = tabIndex;
            xmlDoc.DocumentElement.AppendChild(tabIndexElement);
            xmlDoc.Save(xmlPath);
        }
    }
}
