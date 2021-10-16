using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatsDLL3;

namespace StatsForm2
{
    public partial class statsEntryForm : Form
    {
        StatsClass sClass;
        public statsEntryForm()
        {
            InitializeComponent();
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                float f = (float)Double.Parse(dataEntryTextBox1.Text);
                if(sClass == null)
                {
                    sClass = new StatsClass(f);
                    displayDataListBox.Items.Add("First data stored item value = " + f);
                }
                else
                {
                    sClass.AddData(f);
                    displayDataListBox.Items.Add("New item added to stats: " + f + " mean is now " + sClass.Mean);
                }
            }
            catch (FormatException fe)
            {
                displayDataListBox.Items.Add("Incorrect data format: " + fe.Message);
            }
        }
    }
}
