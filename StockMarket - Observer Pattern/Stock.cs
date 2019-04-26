using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket___Observer_Pattern
{
	public class Stock
	{
        private string name;
		private decimal openingPrice;
        private decimal previousDayPrice;
		private decimal currentPrice;

        public Stock(string name, decimal initialPrice)
        {
            this.name = name;
            openingPrice = initialPrice;
            currentPrice = initialPrice;
        }

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
                decimal priceChange = rng.Next(10, 25) / 100.0m;

                // To avoid repetitive and more or less 50-50 behaviour.
                if (rng.NextDouble() < 1 - rng.NextDouble())
                {
                    newPrice -= priceChange;
                }
                else
                {
                    newPrice += priceChange;
                }
                SetCurrentPrice(newPrice);
            }
        }

        public decimal GetCurrentPrice()
		{
			return currentPrice;
		}

        public decimal GetPreviousDayPrice()
        {
            return previousDayPrice;
        }

        public void SetOpeningPrice(decimal newPrice)
		{
            previousDayPrice = openingPrice;
            openingPrice = newPrice;
		}

		public decimal GetOpeningPrice()
		{
			return openingPrice;
		}
	}
}
