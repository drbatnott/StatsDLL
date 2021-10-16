
namespace UseStatsForm1
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addDataButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(28, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(552, 304);
            this.listBox1.TabIndex = 0;
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(28, 36);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(137, 34);
            this.addDataButton.TabIndex = 1;
            this.addDataButton.Text = "Add Data";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(222, 36);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(545, 31);
            this.dataTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.TextBox dataTextBox;
    }
}

