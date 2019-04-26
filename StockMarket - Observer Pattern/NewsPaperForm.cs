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
    partial class NewsPaperForm : BoardForm, IObserver
    {
        private DateTime date;
        public NewsPaperForm(StockMarket stockMarket) : base(stockMarket)
        {
            InitializeComponent();
            date = DateTime.Today.Date;
            dayLbl.Text = $"Date: {date.Year}-{date.Month}-{date.Day}";
        }

        public void UpdateObservers()
        {
            List<Stock> stocks = stockMarket.GetStocks();
            int stockMarketTime = stockMarket.GetTime();
            // Every second simulates an hour, 24 seconds one day, 
            // the day is over and the newspaper is 'deliverd' every day.
            if ((stockMarketTime % 24000) == 0)
            {
                if (stockMarketTime > 0)
                {
                    date = date.AddDays(1);
                    dayLbl.Text = $"Date: {date.Year}-{date.Month}-{date.Day}";
                }
                UpdateBoard(stocks);
                UpdateDifference(stocks);
            }
        }

        private void NewsPaperForm_FormClosed(object sender, FormClosedEventArgs e)
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
                difference = (stock.GetCurrentPrice() - stock.GetPreviousDayPrice()) / stock.GetPreviousDayPrice();
                if (difference > 0)
                {
                    increaseOrDecrease = "+";
                }
                relativeDifferenceListBox.Items.Add($"{increaseOrDecrease}{difference:0.00}%");
            }
        }
    }
}
