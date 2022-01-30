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
        public static List<KeyValuePair<int, string>> tabNumberRelation = new List<KeyValuePair<int, string>>();

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
                Guid newGUID = Guid.NewGuid();
                NewServerTab(newGUID.ToString(), 1);
            }
            else
            {
                string[] GUIDList = Directory.GetFiles(Application.StartupPath + @"tabs\", "*.xml").Select(Path.GetFileNameWithoutExtension).Select(p => p.Substring(0)).ToArray();
                foreach(string guid in GUIDList)
                {
                    Program.log("Parsed GUID: " + guid);
                    XmlAttributeCollection attributes;
                    XmlDocument doc = new XmlDocument();
                    Program.log(Application.StartupPath + @"tabs\" + guid + ".xml");
                    doc.Load(Application.StartupPath + @"tabs\" + guid + ".xml");
                    XmlNodeList node = doc.GetElementsByTagName("tabIndex");
                    foreach(XmlNode n in node)
                    {
                        string tabIndexFromAttribute = n.Attributes["tabIndex"].Value;
                        int tabIndex = Int16.Parse(tabIndexFromAttribute);
                        tabNumberRelation.Add(new KeyValuePair<int, string>(tabIndex, guid));
                        //NewServerTab(guid, tabIndex);
                    }


                    //NewServerTab();
                    assignedGUIDS.Add(guid);
                }
                Program.log("Unsorted Output:");
                foreach (KeyValuePair<int,string> kvp in tabNumberRelation)
                {
                    Program.log(kvp.Key + " " + kvp.Value);
                }
                quickSort(tabNumberRelation);
                Program.log("Sorted Output:");
                foreach (KeyValuePair<int, string> kvp in tabNumberRelation)
                {
                    Program.log(kvp.Key + " " + kvp.Value);
                }
                foreach(KeyValuePair<int,string> kvp in tabNumberRelation)
                {
                    Program.log(kvp.Key + " " + kvp.Value);
                    NewServerTab(kvp.Value, kvp.Key);
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
            Guid newGUID = Guid.NewGuid();
            NewServerTab(newGUID.ToString() ,tabInstances.Count + 1);
        }

        private void Connector_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (TabPageUserControl tabs in tabInstances)
            {
                    FormSerialisor.Serialise(tabs, Application.StartupPath + @"tabs\" + tabs.localGUID + ".xml");
                    xmlAddTabIndex(tabs.tabIndex, Application.StartupPath + @"tabs\" + tabs.localGUID + ".xml");
                    Program.log(Application.StartupPath + @"tabs\" + tabs.localGUID + ".xml");
                    Program.log("Saving Tab: " + tabs.localGUID);
              
            }
        }

        //Create tabs
        public void NewServerTab(string guid, int tabNumber)
        {
            TabPageUserControl tabUserControl = new TabPageUserControl(guid, tabNumber);
            TabPage page = new TabPage("Server #" + tabNumber);
            tabInstances.Add(tabUserControl);
            tabUserControl.Dock = DockStyle.Fill;
            page.Controls.Add(tabUserControl);
            this.tabControl1.Controls.Add(page);
            this.Update();
        }

        public void xmlAddTabIndex(int tabIndex, String xmlPath)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);

            XmlNode typeNode = doc.CreateElement("tabIndex");
            XmlAttribute type = doc.CreateAttribute("Type");
            XmlAttribute name = doc.CreateAttribute("tabIndex");
            type.Value = "tabIndex";
            name.Value = tabIndex.ToString();
            typeNode.Attributes.Append(type);
            typeNode.Attributes.Append(name);

            doc.DocumentElement.AppendChild(typeNode);
            doc.Save(xmlPath);
        }

        private void Connector_Shown(object sender, EventArgs e)
        {
        
        }
        public static void quickSort(List<KeyValuePair<int,string>> l)
        {
            int pivot, right, left, i, j;
            while (true)
            {
                pivot = l[(int)Math.Floor((double)l.Count / 2)].Key;
                Program.log("Pivot: " + pivot);
                i = 0;
                left = l[i].Key;
                Program.log("Left: " + left);
                while (left < pivot)
                {
                    i++;
                    left = l[i].Key;
                }
                j = l.Count - 1;
                right = l[j].Key;
                Program.log("Right: " + right);
                while (right > pivot)
                {
                    j--;
                    right = l[j].Key;
                }
                if (left == right)
                {
                    return;
                }
                else
                {
                    KeyValuePair<int, string> temp = l[j];
                    l[j] = l[i];
                    l[i] = temp;
                    foreach (KeyValuePair<int, string> kvp in tabNumberRelation)
                    {
                        Program.log(kvp.Key + " " + kvp.Value);
                    }
                }

            }
        }
    }
}
