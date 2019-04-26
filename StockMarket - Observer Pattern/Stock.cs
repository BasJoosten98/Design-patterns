using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket___Observer_Pattern
{
	public class Stock
	{
        private string name;
		private decimal openingPrice;
		private decimal currentPrice;

		public string GetName()
		{
			return name;
		}

		private void SetCurrentPrice(decimal newPrice)
		{
            currentPrice = newPrice;
		}

		public void GeneratePriceUpdate(Random rng)
		{  
            if (rng.NextDouble() < 1 - rng.NextDouble())
            {
                decimal newPrice = GetCurrentPrice();
                decimal priceChange = rng.Next(1, 10) / 100.0m;
                // 0 or 1 just a coin toss for increase or decrease.
                switch (rng.Next(2))
                {
                    case 0:
                        newPrice -= priceChange;
                        break;
                    default:
                        newPrice += priceChange;
                        break;
                }
                SetCurrentPrice(newPrice);
            }
        }

		public decimal GetCurrentPrice()
		{
			return currentPrice;
		}

		public void SetOpeningPrice(decimal newPrice)
		{
			openingPrice = newPrice;
		}

		public decimal GetOpeningPrice()
		{
			return openingPrice;
		}

		public Stock(string name, decimal initialPrice)
		{
			this.name = name;
            openingPrice = initialPrice;
		}
	}
}
