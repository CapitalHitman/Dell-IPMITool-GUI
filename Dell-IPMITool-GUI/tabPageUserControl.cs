using FormSerialisation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Dell_IPMITool_GUI
{
    public partial class TabPageUserControl : UserControl
    {
        public String localGUID;
        public String tabIndex;
        public TabPageUserControl()
        {
            InitializeComponent();
        }

        public TabPageUserControl(String guid, String tabNumber)
        {
            localGUID = guid;
            tabIndex = tabNumber;
            Program.log(Application.StartupPath + @"tabs\" + guid + ".xml");
            InitializeComponent();
        }

        private void tabPageUserControl_Load(object sender, EventArgs e)
        {
            FormSerialisor.Deserialise(this, Application.StartupPath + @"tabs\" + localGUID + ".xml");
        }

        private void ipErrorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        
        private void tabPageUserControl_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }


    }
