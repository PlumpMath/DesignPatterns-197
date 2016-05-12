using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPR_assignments.Extra;

namespace DPR_assignments
{
    public partial class Form1 : Form
    {
        private HelperClass helperClass;
        public Form1()
        {
            InitializeComponent();
            helperClass = new HelperClass();
            listBox1.DataSource = helperClass.GetNumberList();
            trackBar1.SetRange(Constants.MinNumber, Constants.MaxNumber);
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            stopBtn.Enabled = true;
            runBtn.Enabled = false;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopBtn.Enabled = false;
            runBtn.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //trackBar1.Value = 10;
        }
    }
}