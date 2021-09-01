
namespace Dell_IPMITool_GUI.Popups
{
    partial class selectionInvalidPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectionInvalidPopup));
            this.invalidTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invalidTextBox
            // 
            this.invalidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invalidTextBox.Location = new System.Drawing.Point(34, 12);
            this.invalidTextBox.Multiline = true;
            this.invalidTextBox.Name = "invalidTextBox";
            this.invalidTextBox.ReadOnly = true;
            this.invalidTextBox.Size = new System.Drawing.Size(287, 54);
            this.invalidTextBox.TabIndex = 0;
            this.invalidTextBox.Text = "The selected file is not vaild!\r\n(Either because it cannot be accessed, or it is " +
    "not the correct .exe)";
            this.invalidTextBox.TextChanged += new System.EventHandler(this.invalidTextBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(124, 90);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(93, 35);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // selectionInvalidPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 137);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.invalidTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "selectionInvalidPopup";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.selectionInvalidPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox invalidTextBox;
        private System.Windows.Forms.Button okButton;
    }
}