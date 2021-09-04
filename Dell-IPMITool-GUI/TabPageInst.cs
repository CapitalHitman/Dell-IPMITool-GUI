using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dell_IPMITool_GUI
{
    public class TabPageInst : System.Windows.Forms.TabPage
    {
        public TabPageInst(int index)
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameTextError = new System.Windows.Forms.TextBox();
            this.ipText = new System.Windows.Forms.TextBox();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.ipTextError = new System.Windows.Forms.TextBox();



            this.Controls.Add(this.ipTextError);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.nameTextError);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameTextBox);
            this.Location = new System.Drawing.Point(4, 25);
            this.Name = "tabPage" + (index + 1);
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(623, 413);
            this.TabIndex = index;
            this.Text = "Server #" + (index + 1);
            this.UseVisualStyleBackColor = true;


            // 
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
            this.ipTextError.TabStop = false;

        }

        public void changeTabText(string newName)
        {
            this.Text = newName;

        }

        public System.Windows.Forms.TabPage GetTabPage() {
            return this;
        }
        public System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox nameTextError;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.TextBox ipTextError;
        private System.Windows.Forms.TextBox ipTextBox;
    }
}
