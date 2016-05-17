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
    public partial class Form2 : Form
    {
        private WeatherData weatherData;
        private List<Forecaster> forecasters = new List<Forecaster>();
        private int counterTemp;
        private int counterHum;
        private int counterPres;
        private Random rr;

        public Form2()
        {
            InitializeComponent();
            forecasters.Add(new Forecaster(lblPhone));
            forecasters.Add(new Forecaster(lblWatch));
            forecasters.Add(new Forecaster(lblMac));

            weatherData = new WeatherData();
            weatherData.AttachData(forecasters[0]);
            weatherData.AttachData(forecasters[1]);
            weatherData.AttachData(forecasters[2]);

            rr = new Random();
            counterTemp = 5;
            counterHum = 11;
            counterPres = 8;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (forecasters[0].Attached)
            {
                button1.Text = "Attach";
                forecasters[0].Attached = false;
                weatherData.DetachData(forecasters[0]);
            }
            else
            {
                button1.Text = "Detach";
                forecasters[0].Attached = true;
                weatherData.AttachData(forecasters[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (forecasters[1].Attached)
            {
                button2.Text = "Attach";
                forecasters[1].Attached = false;
                weatherData.DetachData(forecasters[1]);
            }
            else
            {
                button2.Text = "Detach";
                forecasters[1].Attached = true;
                weatherData.AttachData(forecasters[1]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (forecasters[2].Attached)
            {
                button3.Text = "Attach";
                forecasters[2].Attached = false;
                weatherData.DetachData(forecasters[2]);
            }
            else
            {
                button3.Text = "Detach";
                forecasters[2].Attached = true;
                weatherData.AttachData(forecasters[2]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Update in: " + Environment.NewLine
                          + "temperature: " + counterTemp + Environment.NewLine
                          + "humidity: " + counterHum + Environment.NewLine
                          + "pressure: " + counterPres;

            if (counterTemp == 0)
            {
                weatherData.Temperature1 = rr.Next(15, 25);
                counterTemp = 5;
            }
            if (counterHum == 0)
            {
                weatherData.Humidity1 = rr.Next(20, 90);
                counterHum = 11;
            }
            if (counterPres == 0)
            {
                weatherData.Pressure = rr.Next(10, 50);
                counterPres = 8;
            }
            counterTemp--;
            counterHum--;
            counterPres--;
        }
    }
}
