using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public abstract class Fruit : ToppingBase
	{
        public Fruit(string name, CakeBase Next)
            : base(name, Next)
        {

        }
	}
}
