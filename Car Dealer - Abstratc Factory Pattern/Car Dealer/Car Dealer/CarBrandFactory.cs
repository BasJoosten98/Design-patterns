using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Dealer
{
	public abstract class CarBrandFactory
	{
        public abstract CompactCar ManufactureCompactCar();

        public abstract Limousine ManufactureLimousine();

        public abstract SUV ManufactureSUV();

        public abstract Hybrid ManufactureHybrid();
	}
}
