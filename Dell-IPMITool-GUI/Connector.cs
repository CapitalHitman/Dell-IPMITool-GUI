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

namespace Dell_IPMITool_GUI
{
    public partial class Connector : Form
    {
        private string ipString;
        private string username;
        private string password;

        private bool inputRemembered;
        

        public Connector()
        {
            InitializeComponent();
        }

        private void Connector_Load(object sender, EventArgs e)
        {
            
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
            Application.Exit();
        }

        //Temporarily store inputs once entered.
        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {
                    ipString = ipTextBox.Text;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
                    username = usernameTextBox.Text;
        }
        
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
                    password = passwordTextBox.Text;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Program.validateIP(ipString);
            Program.validateUsername(username);
            Program.validatePassword(password);



            if (rememberLogin.Checked)
            {
                
            }
        }
    }
}
