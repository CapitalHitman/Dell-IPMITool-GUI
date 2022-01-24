﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormSerialisation;

namespace Dell_IPMITool_GUI
{
    public class TabPageInst : System.Windows.Forms.TabPage
    {
        public TabPageInst(int index)
        {
            this.ipText = new System.Windows.Forms.TextBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.ipErrorTextBox = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameErrorTextBox = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordErrorTextBox = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameErrorTextBox = new System.Windows.Forms.TextBox();
            this.serverSaveButton = new System.Windows.Forms.Button();



            this.Controls.Add(this.serverSaveButton);
            this.Controls.Add(this.nameErrorTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.passwordErrorTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameErrorTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.ipErrorTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ipText);
            this.Location = new System.Drawing.Point(4, 25);
            this.Name = "tabPage" + (index + 1);
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(623, 413);
            this.TabIndex = index;
            this.Text = "Server #" + (index + 1);
            this.UseVisualStyleBackColor = true;


            // 
            // ipText
            // 
            this.ipText.BackColor = System.Drawing.SystemColors.Window;
            this.ipText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipText.Cursor = System.Windows.Forms.Cursors.Default;
            this.ipText.Location = new System.Drawing.Point(9, 74);
            this.ipText.Name = "ipText";
            this.ipText.ReadOnly = true;
            this.ipText.Size = new System.Drawing.Size(224, 15);
            this.ipText.TabIndex = 0;
            this.ipText.TabStop = false;
            this.ipText.Text = "IP Address:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(9, 95);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(224, 22);
            this.ipTextBox.TabIndex = 1;
            // 
            // ipErrorTextBox
            // 
            this.ipErrorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ipErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipErrorTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ipErrorTextBox.Location = new System.Drawing.Point(9, 124);
            this.ipErrorTextBox.Name = "ipErrorTextBox";
            this.ipErrorTextBox.ReadOnly = true;
            this.ipErrorTextBox.Size = new System.Drawing.Size(224, 15);
            this.ipErrorTextBox.TabIndex = 2;
            this.ipErrorTextBox.TabStop = false;
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.SystemColors.Window;
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameText.Location = new System.Drawing.Point(9, 145);
            this.usernameText.Name = "usernameText";
            this.usernameText.ReadOnly = true;
            this.usernameText.Size = new System.Drawing.Size(115, 15);
            this.usernameText.TabIndex = 3;
            this.usernameText.TabStop = false;
            this.usernameText.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(9, 167);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(224, 22);
            this.usernameTextBox.TabIndex = 4;
            // 
            // usernameErrorTextBox
            // 
            this.usernameErrorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameErrorTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameErrorTextBox.Location = new System.Drawing.Point(9, 195);
            this.usernameErrorTextBox.Name = "usernameErrorTextBox";
            this.usernameErrorTextBox.ReadOnly = true;
            this.usernameErrorTextBox.Size = new System.Drawing.Size(221, 15);
            this.usernameErrorTextBox.TabIndex = 5;
            this.usernameErrorTextBox.TabStop = false;
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.SystemColors.Window;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwordText.Location = new System.Drawing.Point(9, 217);
            this.passwordText.Name = "passwordText";
            this.passwordText.ReadOnly = true;
            this.passwordText.Size = new System.Drawing.Size(100, 15);
            this.passwordText.TabIndex = 6;
            this.passwordText.TabStop = false;
            this.passwordText.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(9, 238);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(221, 22);
            this.passwordTextBox.TabIndex = 7;
            // 
            // passwordErrorTextBox
            // 
            this.passwordErrorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordErrorTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwordErrorTextBox.Location = new System.Drawing.Point(9, 267);
            this.passwordErrorTextBox.Name = "passwordErrorTextBox";
            this.passwordErrorTextBox.ReadOnly = true;
            this.passwordErrorTextBox.Size = new System.Drawing.Size(221, 15);
            this.passwordErrorTextBox.TabIndex = 8;
            this.passwordErrorTextBox.TabStop = false;
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.Window;
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameText.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameText.Location = new System.Drawing.Point(9, 7);
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(178, 15);
            this.nameText.TabIndex = 9;
            this.nameText.TabStop = false;
            this.nameText.Text = "Server Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(9, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(221, 22);
            this.nameTextBox.TabIndex = 10;
            // 
            // nameErrorTextBox
            // 
            this.nameErrorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameErrorTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameErrorTextBox.Location = new System.Drawing.Point(9, 57);
            this.nameErrorTextBox.Name = "nameErrorTextBox";
            this.nameErrorTextBox.ReadOnly = true;
            this.nameErrorTextBox.Size = new System.Drawing.Size(221, 15);
            this.nameErrorTextBox.TabIndex = 11;
            this.nameErrorTextBox.TabStop = false;
            // 
            // serverSaveButton
            // 
            this.serverSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.serverSaveButton.ForeColor = System.Drawing.Color.Black;
            this.serverSaveButton.Location = new System.Drawing.Point(320, 295);
            this.serverSaveButton.Name = "serverSaveButton";
            this.serverSaveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverSaveButton.Size = new System.Drawing.Size(138, 35);
            this.serverSaveButton.TabIndex = 13;
            this.serverSaveButton.Text = "Save";
            this.serverSaveButton.UseVisualStyleBackColor = false;

            //this.ClientSize = new System.Drawing.Size(981, 480);

            this.ResumeLayout(false);
            

        }
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.TextBox nameErrorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox passwordErrorTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameErrorTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox ipErrorTextBox;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button serverSaveButton;

        public void changeTabText(string newName)
        {
            this.Text = newName;

        }

        public System.Windows.Forms.TabPage GetTabPage() {
            return this;
        }
    }
}
