using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealer
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDealer bmwCd = new CarDealer(new BMWFactory());
            CarDealer opelCd = new CarDealer(new OpelFactory());

            Console.WriteLine("BWM DEALER SELLS:");
            Console.WriteLine(bmwCd.CompactCar.ToString());
            Console.WriteLine(bmwCd.Limousine);
            Console.WriteLine(bmwCd.Suv);
            Console.WriteLine(bmwCd.Hybrid);

            Console.WriteLine();
            Console.WriteLine("OPEL DEALER SELLS:");
            Console.WriteLine(opelCd.CompactCar);
            Console.WriteLine(opelCd.Limousine);
            Console.WriteLine(opelCd.Suv);
            Console.WriteLine(opelCd.Hybrid);

            Console.Write("Press any key to quit");
            Console.ReadKey();
        }
    }
}
