using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public class ForestFruits : Fruit
	{
        public ForestFruits(string name, CakeBase Next)
            : base(name, Next)
        {

        }
        public override CakeBase Copy()
        {
            CakeBase cb = new ForestFruits(name, NextBase);
            if (NextBase != null)
            {
                ((ToppingBase)cb).NextBase = NextBase.Copy();
            }
            return cb;
        }
    }
}
