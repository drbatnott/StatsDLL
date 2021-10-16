
namespace StatsForm2
{
    partial class statsEntryForm
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
            this.addDataButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataEntryTextBox1 = new System.Windows.Forms.TextBox();
            this.displayDataListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(736, 175);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(172, 76);
            this.addDataButton.TabIndex = 0;
            this.addDataButton.Text = "Add Data";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data To Enter:";
            // 
            // dataEntryTextBox1
            // 
            this.dataEntryTextBox1.Location = new System.Drawing.Point(120, 26);
            this.dataEntryTextBox1.Name = "dataEntryTextBox1";
            this.dataEntryTextBox1.Size = new System.Drawing.Size(806, 23);
            this.dataEntryTextBox1.TabIndex = 2;
            // 
            // displayDataListBox
            // 
            this.displayDataListBox.FormattingEnabled = true;
            this.displayDataListBox.ItemHeight = 15;
            this.displayDataListBox.Location = new System.Drawing.Point(120, 77);
            this.displayDataListBox.Name = "displayDataListBox";
            this.displayDataListBox.Size = new System.Drawing.Size(595, 514);
            this.displayDataListBox.TabIndex = 3;
            // 
            // statsEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 627);
            this.Controls.Add(this.displayDataListBox);
            this.Controls.Add(this.dataEntryTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDataButton);
            this.Name = "statsEntryForm";
            this.Text = "Stats Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataEntryTextBox1;
        private System.Windows.Forms.ListBox displayDataListBox;
    }
}

