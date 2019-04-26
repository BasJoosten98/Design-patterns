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
    public partial class MatrixBoardForm : BoardForm, IObserver
    {
        public MatrixBoardForm(StockMarket stockMarket) : base(stockMarket)
        {
            InitializeComponent();
        }

        public void UpdateObservers()
        {
            List<Stock> stocks = stockMarket.GetStocks();
            UpdateBoard(stocks);
        }

        private void MatrixBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stockMarket.Detach(this);
        }
    }
}
