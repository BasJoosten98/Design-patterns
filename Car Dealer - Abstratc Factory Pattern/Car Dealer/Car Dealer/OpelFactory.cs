using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Dealer
{
	public class OpelFactory : CarBrandFactory
	{
        private const string BRAND = "OPEL";
        public override CompactCar ManufactureCompactCar()
		{
			return new OpelCompactCar($"{BRAND} Compact Car");
		}

		public override Limousine ManufactureLimousine()
		{
            return new OpelLimousine($"{BRAND} Limousine");
        }

		public override SUV ManufactureSUV()
		{
            return new OpelSUV($"{BRAND} SUV");
        }

		public override Hybrid ManufactureHybrid()
		{
            return new OpelHybrid($"{BRAND} Hybrid Car");
		}
	}
}
