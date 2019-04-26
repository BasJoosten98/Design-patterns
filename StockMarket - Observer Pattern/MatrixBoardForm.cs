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
            UpdateDifference(stocks);
        }

        private void MatrixBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stockMarket.Detach(this);
        }

        private void UpdateDifference(List<Stock> stocks)
        {
            decimal difference;
            string increaseOrDecrease = string.Empty;

            foreach (Stock stock in stocks)
            {
                increaseOrDecrease = string.Empty;
                difference = (stock.GetCurrentPrice() - stock.GetOpeningPrice()) / stock.GetOpeningPrice();
                if (difference > 0)
                {
                    increaseOrDecrease = "+";
                }
                relativeDifferenceListBox.Items.Add($"{increaseOrDecrease}{difference:0.00}%");
            }
        }
    }
}
