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
    public partial class BoardForm : Form
    {
        protected StockMarket stockMarket;

        public BoardForm()
        {
            InitializeComponent();
        }

        public BoardForm(StockMarket stockMarket)
        {
            InitializeComponent();
            this.stockMarket = stockMarket;
        }

        protected void UpdateBoard(List<Stock> stocks)
        {
            ClearAllListBoxes();
            foreach(Stock stock in stocks)
            {
                AddStock(stock);
            }
        }

        private void ClearAllListBoxes()
        {
            stockListBox.Items.Clear();
            currentPriceListbox.Items.Clear();
            relativeDifferenceListBox.Items.Clear();
        }

        private void AddStock(Stock stock)
        {
            decimal currentPrice = stock.GetCurrentPrice();

            stockListBox.Items.Add(stock.GetName());
            currentPriceListbox.Items.Add(currentPrice);
        }
    }
}
