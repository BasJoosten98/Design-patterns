using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public abstract class Cream : ToppingBase
	{
        public Cream(string name, CakeBase Next)
            : base(name, Next)
        {

        }
	}
}
