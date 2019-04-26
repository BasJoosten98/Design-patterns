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
        public NewsPaperForm(StockMarket stockMarket) : base(stockMarket)
        {
            InitializeComponent();
            DateTime date = DateTime.Today.Date;
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
                UpdateBoard(stocks);
                DateTime date = DateTime.Today.Date;
                date = date.AddDays(1);
                dayLbl.Text = $"Date: {date.Year}-{date.Month}-{date.Day}";
            }
        }

        private void NewsPaperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stockMarket.Detach(this);
        }
    }
}
