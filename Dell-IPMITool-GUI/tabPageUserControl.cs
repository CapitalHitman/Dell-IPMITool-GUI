using FormSerialisation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Dell_IPMITool_GUI
{
    public partial class tabPageUserControl : UserControl
    {
        public static Guid InstanceID { get; private set; }
        public tabPageUserControl(Guid GUID)
        {
            InstanceID = GUID;
            Program.log("Tab InstanceID: " + InstanceID);
            Connector.tabGUID.Add(InstanceID);
            FormSerialisor.Deserialise(this, Application.StartupPath + @"\tabs\" + GUID + ".xml");
            InitializeComponent();
        }

        public tabPageUserControl()
        {
            InstanceID = Guid.NewGuid();
            Program.log("Tab InstanceID: " + InstanceID);
            Connector.tabGUID.Add(InstanceID);
            InitializeComponent();
        }

        private void tabPageUserControl_Load(object sender, EventArgs e)
        {
            Program.log(Connector.tabNumber);
        }

        private void ipErrorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.log(InstanceID);
        }
        
        private void tabPageUserControl_Leave(object sender, EventArgs e)
        {
            Program.log("Form Closing");
            Program.log(InstanceID);
            FormSerialisor.Serialise(this, Application.StartupPath + @"\tabs\" + InstanceID + ".xml");
        }
    }


    }
