using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Dealer
{
	public class BMWFactory : CarBrandFactory
	{
        private const string BRAND = "BWM";
		public override CompactCar ManufactureCompactCar()
		{
			return new BMWCompactCar($"{BRAND} Compact car");
		}

		public override Limousine ManufactureLimousine()
		{
			return new BMWLimousine($"{BRAND} Limousine");
		}

		public override SUV ManufactureSUV()
		{
			return new BMWSUV($"{BRAND} SUV");
		}

		public override Hybrid ManufactureHybrid()
		{
            return new BMWHybrid($"{BRAND} Hybrid");
		}
	}
}
