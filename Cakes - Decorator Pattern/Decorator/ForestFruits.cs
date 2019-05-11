using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public class ForestFruits : Fruit
	{
        public ForestFruits(string name)
            :base(name)
        {

        }
        public override CakeBase Copy()
        {
            CakeBase cb = new ForestFruits(name);
            if (NextBase != null)
            {
                ((ToppingBase)cb).NextBase = NextBase.Copy();
            }
            return cb;
        }
    }
}
