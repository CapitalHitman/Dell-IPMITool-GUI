
namespace Dell_IPMITool_GUI
{
    partial class tabPageUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
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
            this.nameErrorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipText
            // 
            this.ipText.BackColor = System.Drawing.SystemColors.Window;
            this.ipText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipText.Cursor = System.Windows.Forms.Cursors.Default;
            this.ipText.Location = new System.Drawing.Point(9, 16);
            this.ipText.Name = "ipText";
            this.ipText.ReadOnly = true;
            this.ipText.Size = new System.Drawing.Size(224, 15);
            this.ipText.TabIndex = 0;
            this.ipText.TabStop = false;
            this.ipText.Text = "IP Address:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(9, 37);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(224, 22);
            this.ipTextBox.TabIndex = 1;
            // 
            // ipErrorTextBox
            // 
            this.ipErrorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ipErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipErrorTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ipErrorTextBox.Location = new System.Drawing.Point(9, 137);
            this.ipErrorTextBox.Name = "ipErrorTextBox";
            this.ipErrorTextBox.ReadOnly = true;
            this.ipErrorTextBox.Size = new System.Drawing.Size(224, 15);
            this.ipErrorTextBox.TabIndex = 2;
            this.ipErrorTextBox.TabStop = false;
            this.ipErrorTextBox.TextChanged += new System.EventHandler(this.ipErrorTextBox_TextChanged);
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.SystemColors.Window;
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameText.Location = new System.Drawing.Point(9, 87);
            this.usernameText.Name = "usernameText";
            this.usernameText.ReadOnly = true;
            this.usernameText.Size = new System.Drawing.Size(115, 15);
            this.usernameText.TabIndex = 3;
            this.usernameText.TabStop = false;
            this.usernameText.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(9, 109);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(224, 22);
            this.usernameTextBox.TabIndex = 4;
            // 
            // usernameErrorTextBox
            // 
            this.usernameErrorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameErrorTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameErrorTextBox.Location = new System.Drawing.Point(9, 208);
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
            this.passwordText.Location = new System.Drawing.Point(9, 159);
            this.passwordText.Name = "passwordText";
            this.passwordText.ReadOnly = true;
            this.passwordText.Size = new System.Drawing.Size(100, 15);
            this.passwordText.TabIndex = 6;
            this.passwordText.TabStop = false;
            this.passwordText.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(9, 180);
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
            // nameErrorTextBox
            // 
            this.nameErrorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameErrorTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameErrorTextBox.Location = new System.Drawing.Point(9, 65);
            this.nameErrorTextBox.Name = "nameErrorTextBox";
            this.nameErrorTextBox.ReadOnly = true;
            this.nameErrorTextBox.Size = new System.Drawing.Size(221, 15);
            this.nameErrorTextBox.TabIndex = 11;
            this.nameErrorTextBox.TabStop = false;
            // 
            // tabPageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.nameErrorTextBox);
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
            this.Name = "tabPageUserControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(623, 413);
            this.Load += new System.EventHandler(this.tabPageUserControl_Load);
            this.Leave += new System.EventHandler(this.tabPageUserControl_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.TextBox nameErrorTextBox;
        private System.Windows.Forms.TextBox passwordErrorTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameErrorTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox ipErrorTextBox;
        private System.Windows.Forms.TextBox ipTextBox;
    }
}
