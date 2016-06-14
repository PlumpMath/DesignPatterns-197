using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6_Command
{
    public partial class Form1 : Form
    {
        private StockTrade _sTrade;
        private Agent _agent;
        private BuyStockOrder _bStock;
        private SellStockOrder _sStock;

        public Form1()
        {
            InitializeComponent();
            _sTrade = new StockTrade();
            _agent = new Agent();
            _bStock = new BuyStockOrder(_sTrade);
            _sStock = new SellStockOrder(_sTrade);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _agent.PlaceOrder(_bStock);
            RefreshListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _agent.PlaceOrder(_sStock);
            RefreshListBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _agent.PerformOrder();
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBox1.Items.Clear();
            foreach (var order in _agent.OrderList)
            {
                listBox1.Items.Add(order.ToString());
            }
        }
    }
}