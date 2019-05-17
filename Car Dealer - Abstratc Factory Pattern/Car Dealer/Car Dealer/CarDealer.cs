using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Dealer
{
	public class CarDealer
	{
        private CarBrandFactory factory;

        public CompactCar CompactCar { get; set; }
        public Limousine Limousine { get; set; }
        public SUV Suv { get; set; }
        public Hybrid Hybrid { get; set; }

        public CarDealer(CarBrandFactory factory)
		{
			this.factory = factory;
            CreateCars();

        }

		public void CreateCars()
		{
            CompactCar = factory.ManufactureCompactCar();
            Limousine = factory.ManufactureLimousine();
            Suv = factory.ManufactureSUV();
            Hybrid = factory.ManufactureHybrid();
		}
	}
}
