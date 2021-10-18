using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewStatsDLL;

namespace UseNewStatsDLL
{
    public partial class TestDLLForm : Form
    {
        /// <summary>
        /// statsClass4 with the little s is an object of type StatsClass4 with the S
        /// 
        /// </summary>
        
        StatsClass4 statsClass4;
        public TestDLLForm()
        {
            InitializeComponent();
            statsClass4 = new StatsClass4();
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            float f =(float)Double.Parse(dataTextBox.Text);
            statsClass4.AddData(f);
            testResultListBox.Items.Add("New data Item " + f);
            testResultListBox.Items.Add("Mean is now " + statsClass4.Mean);
            testResultListBox.Items.Add("Median is now " + statsClass4.Median);
        }
    }
}
