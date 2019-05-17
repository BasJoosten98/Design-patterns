using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealer
{
    public abstract class Car
    {
        public string Name { get; }

        public Car(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
