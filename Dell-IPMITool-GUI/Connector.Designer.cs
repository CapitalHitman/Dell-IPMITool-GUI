
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
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ipText = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rememberLogin = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(62, 211);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(294, 22);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 28);
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
            // ipText
            // 
            this.ipText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipText.Location = new System.Drawing.Point(62, 190);
            this.ipText.Name = "ipText";
            this.ipText.ReadOnly = true;
            this.ipText.Size = new System.Drawing.Size(105, 15);
            this.ipText.TabIndex = 3;
            this.ipText.Text = "IPMI IP Address:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(62, 271);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(294, 22);
            this.usernameTextBox.TabIndex = 4;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(62, 328);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(294, 22);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // usernameText
            // 
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Location = new System.Drawing.Point(62, 250);
            this.usernameText.Name = "usernameText";
            this.usernameText.ReadOnly = true;
            this.usernameText.Size = new System.Drawing.Size(114, 15);
            this.usernameText.TabIndex = 6;
            this.usernameText.Text = "Username:";
            // 
            // passwordText
            // 
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Location = new System.Drawing.Point(62, 307);
            this.passwordText.Name = "passwordText";
            this.passwordText.ReadOnly = true;
            this.passwordText.Size = new System.Drawing.Size(100, 15);
            this.passwordText.TabIndex = 7;
            this.passwordText.Text = "Password:";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(226, 386);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(130, 36);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(62, 386);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(114, 35);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dell_IPMITool_GUI.Properties.Resources.settings128;
            this.pictureBox2.Location = new System.Drawing.Point(123, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
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
            // 
            // rememberLogin
            // 
            this.rememberLogin.AutoSize = true;
            this.rememberLogin.Location = new System.Drawing.Point(62, 357);
            this.rememberLogin.Name = "rememberLogin";
            this.rememberLogin.Size = new System.Drawing.Size(138, 21);
            this.rememberLogin.TabIndex = 10;
            this.rememberLogin.Text = "Remember Login";
            this.rememberLogin.UseVisualStyleBackColor = true;
            // 
            // Connector
            // 
            this.AcceptButton = this.connectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(421, 510);
            this.Controls.Add(this.rememberLogin);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ipTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox rememberLogin;
    }
}

