using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2_Observer
{
    public partial class Form1 : Form
    {
        private Eindhoven endh;
        private Amsterdam amst;
        private List<Forecaster> forecasters = new List<Forecaster>();
        private int counter;
        private Random rr;

        public Form1()
        {
            InitializeComponent();
            forecasters.Add(new Forecaster(lblPhone));
            forecasters.Add(new Forecaster(lblWatch));
            forecasters.Add(new Forecaster(lblMac));

            endh = new Eindhoven("Celsius", 20);
            amst = new Amsterdam("Fahrenheit", 68);

            endh.Attach(forecasters[0]);
            endh.Attach(forecasters[1]);
            amst.Attach(forecasters[2]);

            rr = new Random();
            counter = 5;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (forecasters[0].Attached)
            {
                button1.Text = "Attach";
                forecasters[0].Attached = false;
                endh.Detach(forecasters[0]);
            }
            else
            {
                button1.Text = "Detach";
                forecasters[0].Attached = true;
                endh.Attach(forecasters[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (forecasters[1].Attached)
            {
                button2.Text = "Attach";
                forecasters[1].Attached = false;
                endh.Detach(forecasters[1]);
            }
            else
            {
                button2.Text = "Detach";
                forecasters[1].Attached = true;
                endh.Attach(forecasters[1]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (forecasters[2].Attached)
            {
                button3.Text = "Attach";
                forecasters[2].Attached = false;
                amst.Detach(forecasters[2]);
            }
            else
            {
                button3.Text = "Detach";
                forecasters[2].Attached = true;
                amst.Attach(forecasters[2]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                endh.Temperature = rr.Next(15, 25);
                amst.Temperature = rr.Next(55, 75);
                counter = 5;
                label2.Text = "Updating";
            }

            label2.Text = "Update in: " + counter;
            counter --;
        }
    }
}