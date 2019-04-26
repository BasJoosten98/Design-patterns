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
    }
}
