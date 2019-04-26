using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket___Observer_Pattern
{
    public partial class mainForm : Form
    {
        private BoardForm matrixBoardForm;
        private BoardForm newsPaperForm;

        private StockMarket stockMarket;

        public mainForm()
        {
            InitializeComponent();

            stockMarket = new StockMarket("AEX");
            List<Stock> stocks = new List<Stock>
            {
                // Prices based on opening prices of 2019-04-26
                new Stock("ABN AMRO", 20.560m),
                new Stock("Ahold Delhaize", 21.320m),
                new Stock("Heineken", 95.220m),
                new Stock("ING Groep", 11.254m),
                new Stock("Royal Dutch Shell A", 28.555m)
            };

            foreach (Stock stock in stocks)
            {
                stockMarket.AddStock(stock);
            } 
        }

        private void OpenMatrixBoardBtn_Click(object sender, EventArgs e)
        {
            if (matrixBoardForm == null || matrixBoardForm.IsDisposed)
            {
                matrixBoardForm = new MatrixBoardForm(stockMarket);
                SetBoardProperties(matrixBoardForm, "Matrix Board", Color.DarkSalmon);
                // Attach
                stockMarket.Attach((IObserver)matrixBoardForm);
            }
            matrixBoardForm.Show();
        }

        private void OpenNewsPaperBtn_Click(object sender, EventArgs e)
        {
            if (newsPaperForm == null || newsPaperForm.IsDisposed)
            {
                newsPaperForm = new NewsPaperForm(stockMarket);
                SetBoardProperties(newsPaperForm, "News Paper", Color.LightSeaGreen);
                stockMarket.Attach((IObserver)newsPaperForm);
            }
            newsPaperForm.Show();
        }

        private void SetBoardProperties(BoardForm board, string text, Color boardColor)
        {
            board.Text = text;
            board.BackColor = boardColor;
        }

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            if (startStopBtn.Text == "Start")
            {
                if (matrixBoardForm != null || newsPaperForm != null)
                {
                    stockMarketTimer.Start();
                    startStopBtn.Text = "Stop";
                }
            }
            else
            {
                stockMarketTimer.Stop();
                startStopBtn.Text = "Start";
            }
        }

        private void stockMarketTimer_Tick_1(object sender, EventArgs e)
        {
            stockMarket.GeneratePriceUpdates();
            stockMarket.IncrementTime(stockMarketTimer.Interval);
        }
    }
}

