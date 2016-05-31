using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4_AbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<ICarFactory> carList = new List<ICarFactory>();
            carList.Add(new Kia());
            carList.Add(new Opel());
            carList.Add(new Peugeo());
            listBox1.DataSource = carList;

            List<ICarType> carTypes = new List<ICarType>();
            carTypes.Add(new Hybrid());
            carTypes.Add(new SUV());
            listBox2.DataSource = carTypes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
            {
                ICarFactory factory = listBox1.SelectedItem as ICarFactory;
                ICarType t = listBox2.SelectedItem as ICarType;

                label1.Text = factory.GetType().Name;
                if (t is SUV)
                {
                    ISUV temp = factory.CreateSUV();
                    label1.Text += " " +temp.OffRoadDriving() + " " + temp.Sell();
                }
                if (t is Hybrid)
                {
                    IHybrid temp = factory.CreateHybrid();
                    label1.Text += " " +temp.ChargeCar() + " " + temp.Sell();
                }
            }
        }
    }

}
