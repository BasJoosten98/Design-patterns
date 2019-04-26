using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket___Observer_Pattern
{
    partial class BoardForm : Form
    {
        protected StockMarket stockMarket;
        public BoardForm(StockMarket stockMarket)
        {
            InitializeComponent();
            this.stockMarket = stockMarket;
        }
    }
}
