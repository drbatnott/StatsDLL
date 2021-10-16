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
namespace UseStatsForm1
{
    public partial class Form1 : Form
    {
        StatsClass statsClass;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            if (dataTextBox.Text == null)
            {
                listBox1.Items.Add("No Data Present");
            }
            else
            {
                try
                {
                    float f = (float)Double.Parse(dataTextBox.Text);
                    if(statsClass == null)
                    {
                        statsClass = new StatsClass(f);
                        listBox1.Items.Add("Current Mean " + statsClass.Mean);
                    }
                    else
                    {
                        statsClass.AddData(f);
                        listBox1.Items.Add("Current Mean " + statsClass.Mean);
                    }
                }
                catch (FormatException fe)
                {
                    listBox1.Items.Add(fe.Message);
                }
            }
        }
    }
}
