using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbuzzcoffee
{
    public partial class Form1 : Form
    {
        IFordTaurus _myFordTaurus;  
        LayerDecorator _myLayer;//Layer variable
        private int _counter; //upgrade counter

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = false;
            this.btnFinalize.Enabled = false;
            this.rbAirco.Enabled = false;
            this.rbSnowTires.Enabled = false;
            this.rbPushBumper.Enabled = false;
            this.rbEntsys.Enabled = false;
            this.rbPerform.Enabled = false;
            this.rbNav.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = true;
            this.btnFinalize.Enabled = true;
            this.rbAirco.Enabled = true;
            this.rbSnowTires.Enabled = true;
            this.rbPushBumper.Enabled = true;
            this.rbEntsys.Enabled = true;
            this.rbPerform.Enabled = true;
            this.rbNav.Enabled = true;


            _myFordTaurus = new NonDecoratedFord();
            _counter = 0; 

            this.label1.Text = "Final Result: "; 
            this.listBox1.Items.Clear();
        }
       
        
        private void FillListbox(string s) 
        {
            this.listBox1.Items.Add("You have added: " + s + ", to your Ford Taurus");
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Finalize Ford Taurus cost: " + _myFordTaurus.Price() + ", Usability Rating: " + _myFordTaurus.Rating() + " Total Upgrades: " + _counter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IFordTaurus x;

            if(this.rbAirco.Checked)
            {
                x = _myFordTaurus;
                _myLayer = new Airco(x);
                _myFordTaurus = _myLayer;

                FillListbox(((Airco)_myLayer).GetLayerInfo());
                _counter++;
            }

            else if(this.rbSnowTires.Checked)
            {
                x = _myFordTaurus;
                _myLayer = new SnowTires(x);
                _myFordTaurus = _myLayer;

                FillListbox(((SnowTires)_myLayer).GetLayerInfo());
                _counter++;
            }

            else if (this.rbPushBumper.Checked)
            {
                x = _myFordTaurus;
                _myLayer = new PushBumper(x);
                _myFordTaurus = _myLayer;

                FillListbox(((PushBumper)_myLayer).GetLayerInfo());
                _counter++;
            }
            else if (this.rbEntsys.Checked)
            {
                x = _myFordTaurus;
                _myLayer = new EntertainmentPkg(x);
                _myFordTaurus = _myLayer;
                
                FillListbox(((EntertainmentPkg)_myLayer).GetLayerInfo());
                _counter++;
            }
            else if (this.rbPerform.Checked)
            {
                x = _myFordTaurus;
                _myLayer = new V8Performance(x);
                _myFordTaurus = _myLayer;

                FillListbox(((V8Performance)_myLayer).GetLayerInfo());
                _counter++;
            }
            else if (this.rbNav.Checked)
            {
                x = _myFordTaurus;
                _myLayer = new Navsystem(x);
                _myFordTaurus = _myLayer;

                FillListbox(((Navsystem)_myLayer).GetLayerInfo());
                _counter++;
            }
        }
    }
}
