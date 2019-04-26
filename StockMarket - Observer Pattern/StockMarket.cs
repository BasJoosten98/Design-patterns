using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket___Observer_Pattern
{
	public class StockMarket : SubjectBase
	{
        private static Random rng;

        private string name;
        private int stockMarketTime;
        private List<Stock> stocks;

		public StockMarket(string name)
		{
            rng = new Random();

            this.name = name;
            stockMarketTime = 0;
            stocks = new List<Stock>();
        }

		public string GetName()
		{
			return name;
		}

        public int GetTime()
        {
            return stockMarketTime;
        }

        public void IncrementTime(int amount)
        {
            stockMarketTime += amount;
            if (stockMarketTime % 2400 == 0)
            {
                // Update all opening prices.
                NewDay();
            }
        }

        public void AddStock(Stock stock)
		{
			foreach (Stock currentStock in stocks)
            {
                if (stock == currentStock)
                {
                    return;
                }
            }
            stocks.Add(stock);
		}

		public void RemoveStock(Stock stock)
		{
			if (stocks.Count > 0)
            {
                stocks.Remove(stock);
            }
		}

		public void GeneratePriceUpdates()
		{
			foreach (Stock stock in stocks)
            {
                stock.GeneratePriceUpdate(rng);
            }
            Notify();
		}

        private void NewDay()
        {
            foreach (Stock stock in stocks)
            {
                // New day thus assign the current price to being the new opening price.
                stock.SetOpeningPrice(stock.GetCurrentPrice());
            }
        }


        public List<Stock> GetStocks()
		{
			return new List<Stock>(stocks);
		}
	}
}
