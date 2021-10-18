
namespace UseNewStatsDLL
{
    partial class TestDLLForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.testResultListBox = new System.Windows.Forms.ListBox();
            this.addDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data To Add";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(162, 19);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(200, 23);
            this.dataTextBox.TabIndex = 1;
            // 
            // testResultListBox
            // 
            this.testResultListBox.FormattingEnabled = true;
            this.testResultListBox.ItemHeight = 15;
            this.testResultListBox.Location = new System.Drawing.Point(155, 76);
            this.testResultListBox.Name = "testResultListBox";
            this.testResultListBox.Size = new System.Drawing.Size(357, 379);
            this.testResultListBox.TabIndex = 2;
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(553, 130);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(109, 54);
            this.addDataButton.TabIndex = 3;
            this.addDataButton.Text = "Add Data To Test";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // TestDLLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 483);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.testResultListBox);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TestDLLForm";
            this.Text = "Test Our Stats DLL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.ListBox testResultListBox;
        private System.Windows.Forms.Button addDataButton;
    }
}

