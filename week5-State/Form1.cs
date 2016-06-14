using System;
using System.Windows.Forms;

namespace State_Pattern___Mathematical_game
{
    public partial class Form1 : Form
    {
        GameAccount _gAccount;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _gAccount = new GameAccount(textBox1.Text, label2, label4);
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _gAccount.ConfirmAnswer((double) numericUpDown1.Value);
        }
    }
}