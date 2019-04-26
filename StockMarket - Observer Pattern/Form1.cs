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
    public partial class mainForm : Form
    {
        private BoardForm matrixBoardForm;
        private BoardForm newsPaperForm;

        private StockMarket stockMarket;

        public mainForm()
        {
            InitializeComponent();
            stockMarket = new StockMarket();
        }

        private void openMatrixBoardBtn_Click(object sender, EventArgs e)
        {
            if (matrixBoardForm == null || matrixBoardForm.IsDisposed)
            {
                matrixBoardForm = new MatrixBoardForm(stockMarket);
                SetBoardProperties(matrixBoardForm, "Matrix Board", Color.DarkSalmon);
            }
            matrixBoardForm.Show();
        }

        private void openNewsPaperBtn_Click(object sender, EventArgs e)
        {
            if (newsPaperForm == null || newsPaperForm.IsDisposed)
            {
                newsPaperForm = new NewsPaperForm(stockMarket);
                SetBoardProperties(newsPaperForm, "News Paper", Color.LightSeaGreen);
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
            stockMarketTimer.Start();
        }
    }
}

