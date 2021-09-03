
namespace Dell_IPMITool_GUI
{
    partial class Connector
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connector));
            this.ipQuickConnectTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickConnectIPText = new System.Windows.Forms.TextBox();
            this.usernameQuickConnectTextBox = new System.Windows.Forms.TextBox();
            this.passwordQuickConnectTextBox = new System.Windows.Forms.TextBox();
            this.quickConnectUsernameText = new System.Windows.Forms.TextBox();
            this.quicckConnectPasswordText = new System.Windows.Forms.TextBox();
            this.quickConnectConnectButton = new System.Windows.Forms.Button();
            this.quickConnectCloseButton = new System.Windows.Forms.Button();
            this.rememberLogin = new System.Windows.Forms.CheckBox();
            this.quickConnectTextbox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();

            this.tabPage1 = new TabPageInst(0);
            
            this.tabPage1Tabby = this.tabPage1.GetTabPage();
/*            this.tabPage1 = new System.Windows.Forms.TabPage();
*/

            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.validationErrorBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
/*            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameTextError = new System.Windows.Forms.TextBox();
            this.ipText = new System.Windows.Forms.TextBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.ipTextError = new System.Windows.Forms.TextBox();*/
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1Tabby.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ipQuickConnectTextBox
            // 
            this.ipQuickConnectTextBox.Location = new System.Drawing.Point(23, 168);
            this.ipQuickConnectTextBox.Name = "ipQuickConnectTextBox";
            this.ipQuickConnectTextBox.Size = new System.Drawing.Size(294, 22);
            this.ipQuickConnectTextBox.TabIndex = 0;
            this.ipQuickConnectTextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.addNewServerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // addNewServerToolStripMenuItem
            // 
            this.addNewServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newServerToolStripMenuItem});
            this.addNewServerToolStripMenuItem.Name = "addNewServerToolStripMenuItem";
            this.addNewServerToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.addNewServerToolStripMenuItem.Text = "File";
            // 
            // newServerToolStripMenuItem
            // 
            this.newServerToolStripMenuItem.Image = global::Dell_IPMITool_GUI.Properties.Resources.server1;
            this.newServerToolStripMenuItem.Name = "newServerToolStripMenuItem";
            this.newServerToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.newServerToolStripMenuItem.Text = "New Server";
            this.newServerToolStripMenuItem.Click += new System.EventHandler(this.newServerToolStripMenuItem_Click);
            // 
            // quickConnectIPText
            // 
            this.quickConnectIPText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quickConnectIPText.Location = new System.Drawing.Point(23, 147);
            this.quickConnectIPText.Name = "quickConnectIPText";
            this.quickConnectIPText.ReadOnly = true;
            this.quickConnectIPText.Size = new System.Drawing.Size(105, 15);
            this.quickConnectIPText.TabIndex = 3;
            this.quickConnectIPText.TabStop = false;
            this.quickConnectIPText.Text = "IPMI IP Address:";
            // 
            // usernameQuickConnectTextBox
            // 
            this.usernameQuickConnectTextBox.Location = new System.Drawing.Point(23, 217);
            this.usernameQuickConnectTextBox.Name = "usernameQuickConnectTextBox";
            this.usernameQuickConnectTextBox.Size = new System.Drawing.Size(294, 22);
            this.usernameQuickConnectTextBox.TabIndex = 4;
            this.usernameQuickConnectTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordQuickConnectTextBox
            // 
            this.passwordQuickConnectTextBox.Location = new System.Drawing.Point(23, 266);
            this.passwordQuickConnectTextBox.Name = "passwordQuickConnectTextBox";
            this.passwordQuickConnectTextBox.Size = new System.Drawing.Size(294, 22);
            this.passwordQuickConnectTextBox.TabIndex = 5;
            this.passwordQuickConnectTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordQuickConnectTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // quickConnectUsernameText
            // 
            this.quickConnectUsernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quickConnectUsernameText.Location = new System.Drawing.Point(23, 196);
            this.quickConnectUsernameText.Name = "quickConnectUsernameText";
            this.quickConnectUsernameText.ReadOnly = true;
            this.quickConnectUsernameText.Size = new System.Drawing.Size(114, 15);
            this.quickConnectUsernameText.TabIndex = 6;
            this.quickConnectUsernameText.TabStop = false;
            this.quickConnectUsernameText.Text = "Username:";
            // 
            // quicckConnectPasswordText
            // 
            this.quicckConnectPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quicckConnectPasswordText.Location = new System.Drawing.Point(23, 245);
            this.quicckConnectPasswordText.Name = "quicckConnectPasswordText";
            this.quicckConnectPasswordText.ReadOnly = true;
            this.quicckConnectPasswordText.Size = new System.Drawing.Size(100, 15);
            this.quicckConnectPasswordText.TabIndex = 7;
            this.quicckConnectPasswordText.TabStop = false;
            this.quicckConnectPasswordText.Text = "Password:";
            // 
            // quickConnectConnectButton
            // 
            this.quickConnectConnectButton.Location = new System.Drawing.Point(179, 321);
            this.quickConnectConnectButton.Name = "quickConnectConnectButton";
            this.quickConnectConnectButton.Size = new System.Drawing.Size(138, 35);
            this.quickConnectConnectButton.TabIndex = 8;
            this.quickConnectConnectButton.Text = "Connect";
            this.quickConnectConnectButton.UseVisualStyleBackColor = true;
            this.quickConnectConnectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // quickConnectCloseButton
            // 
            this.quickConnectCloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quickConnectCloseButton.Location = new System.Drawing.Point(23, 321);
            this.quickConnectCloseButton.Name = "quickConnectCloseButton";
            this.quickConnectCloseButton.Size = new System.Drawing.Size(138, 35);
            this.quickConnectCloseButton.TabIndex = 9;
            this.quickConnectCloseButton.Text = "Close";
            this.quickConnectCloseButton.UseVisualStyleBackColor = true;
            this.quickConnectCloseButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // rememberLogin
            // 
            this.rememberLogin.AutoSize = true;
            this.rememberLogin.Location = new System.Drawing.Point(23, 294);
            this.rememberLogin.Name = "rememberLogin";
            this.rememberLogin.Size = new System.Drawing.Size(138, 21);
            this.rememberLogin.TabIndex = 10;
            this.rememberLogin.Text = "Remember Login";
            this.rememberLogin.UseVisualStyleBackColor = true;
            // 
            // quickConnectTextbox
            // 
            this.quickConnectTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quickConnectTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.quickConnectTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickConnectTextbox.Location = new System.Drawing.Point(656, 5);
            this.quickConnectTextbox.Name = "quickConnectTextbox";
            this.quickConnectTextbox.ReadOnly = true;
            this.quickConnectTextbox.Size = new System.Drawing.Size(294, 20);
            this.quickConnectTextbox.TabIndex = 12;
            this.quickConnectTextbox.TabStop = false;
            this.quickConnectTextbox.Text = "Quick Connect";
            this.quickConnectTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ipQuickConnectTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.validationErrorBox);
            this.splitContainer1.Panel2.Controls.Add(this.usernameQuickConnectTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.quickConnectConnectButton);
            this.splitContainer1.Panel2.Controls.Add(this.quickConnectCloseButton);
            this.splitContainer1.Panel2.Controls.Add(this.rememberLogin);
            this.splitContainer1.Panel2.Controls.Add(this.quickConnectIPText);
            this.splitContainer1.Panel2.Controls.Add(this.passwordQuickConnectTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.quicckConnectPasswordText);
            this.splitContainer1.Panel2.Controls.Add(this.quickConnectUsernameText);
            this.splitContainer1.Size = new System.Drawing.Size(981, 445);
            this.splitContainer1.SplitterDistance = 629;
            this.splitContainer1.TabIndex = 13;




            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1Tabby);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 442);
            this.tabControl1.TabIndex = 0;
            /*
             
             for (int i; i<this.TabArray.length;i++) {
                this.tabControl1.Controls.Add(this.TabArray[i].GetTabPage());
            }
             */

/*            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ipTextError);
            this.tabPage1.Controls.Add(this.ipTextBox);
            this.tabPage1.Controls.Add(this.ipText);
            this.tabPage1.Controls.Add(this.nameTextError);
            this.tabPage1.Controls.Add(this.nameText);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server #1";
            this.tabPage1.UseVisualStyleBackColor = true;*/
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dell_IPMITool_GUI.Properties.Resources.settings128;
            this.pictureBox2.Location = new System.Drawing.Point(23, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // validationErrorBox
            // 
            this.validationErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.validationErrorBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.validationErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationErrorBox.ForeColor = System.Drawing.Color.Red;
            this.validationErrorBox.Location = new System.Drawing.Point(23, 362);
            this.validationErrorBox.Name = "validationErrorBox";
            this.validationErrorBox.ReadOnly = true;
            this.validationErrorBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.validationErrorBox.Size = new System.Drawing.Size(294, 71);
            this.validationErrorBox.TabIndex = 11;
            this.validationErrorBox.TabStop = false;
            this.validationErrorBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Dell_IPMITool_GUI.Properties.Resources.settings128;
            this.pictureBox1.Location = new System.Drawing.Point(149, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
/*            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(8, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(245, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.Window;
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameText.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameText.Location = new System.Drawing.Point(8, 6);
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(100, 15);
            this.nameText.TabIndex = 1;
            this.nameText.TabStop = false;
            this.nameText.Text = "Name:";
            // 
            // nameTextError
            // 
            this.nameTextError.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextError.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nameTextError.Location = new System.Drawing.Point(9, 56);
            this.nameTextError.Name = "nameTextError";
            this.nameTextError.ReadOnly = true;
            this.nameTextError.Size = new System.Drawing.Size(244, 15);
            this.nameTextError.TabIndex = 2;
            this.nameTextError.TabStop = false;
            // 
            // ipText
            // 
            this.ipText.BackColor = System.Drawing.SystemColors.Window;
            this.ipText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipText.Cursor = System.Windows.Forms.Cursors.Default;
            this.ipText.Location = new System.Drawing.Point(9, 81);
            this.ipText.Name = "ipText";
            this.ipText.ReadOnly = true;
            this.ipText.Size = new System.Drawing.Size(100, 15);
            this.ipText.TabIndex = 3;
            this.ipText.TabStop = false;
            this.ipText.Text = "IP Address:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(9, 103);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(244, 22);
            this.ipTextBox.TabIndex = 4;
            // 
            // ipTextError
            // 
            this.ipTextError.BackColor = System.Drawing.SystemColors.Window;
            this.ipTextError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipTextError.Cursor = System.Windows.Forms.Cursors.Default;
            this.ipTextError.Location = new System.Drawing.Point(9, 132);
            this.ipTextError.Name = "ipTextError";
            this.ipTextError.ReadOnly = true;
            this.ipTextError.Size = new System.Drawing.Size(244, 15);
            this.ipTextError.TabIndex = 5;
            this.ipTextError.TabStop = false;*/
            // 
            // Connector
            // 
            this.AcceptButton = this.quickConnectConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.quickConnectCloseButton;
            this.ClientSize = new System.Drawing.Size(981, 480);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.quickConnectTextbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Connector";
            this.Text = "Dell IPMITool GUI";
            this.Load += new System.EventHandler(this.Connector_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            /*            this.tabPage1.ResumeLayout(false);
                        this.tabPage1.PerformLayout();*/

            this.tabPage1Tabby.ResumeLayout(false);
            this.tabPage1Tabby.PerformLayout();


            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipQuickConnectTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox quickConnectIPText;
        private System.Windows.Forms.TextBox usernameQuickConnectTextBox;
        private System.Windows.Forms.TextBox passwordQuickConnectTextBox;
        private System.Windows.Forms.TextBox quickConnectUsernameText;
        private System.Windows.Forms.TextBox quicckConnectPasswordText;
        private System.Windows.Forms.Button quickConnectConnectButton;
        private System.Windows.Forms.Button quickConnectCloseButton;
        private System.Windows.Forms.CheckBox rememberLogin;
        private System.Windows.Forms.ToolStripMenuItem addNewServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newServerToolStripMenuItem;
        private System.Windows.Forms.TextBox quickConnectTextbox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
/*        private System.Windows.Forms.TabPage tabPage1;*/
        private System.Windows.Forms.RichTextBox validationErrorBox;
        /*       private System.Windows.Forms.TextBox nameText;
               private System.Windows.Forms.TextBox nameTextBox;
               private System.Windows.Forms.TextBox nameTextError;
               private System.Windows.Forms.TextBox ipText;
               private System.Windows.Forms.TextBox ipTextError;
               private System.Windows.Forms.TextBox ipTextBox;*/

        private TabPageInst tabPage1;
        private System.Windows.Forms.TabPage tabPage1Tabby;

    }
}

