using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public class FruitCake : CakeBase
	{
        public FruitCake(string name)
            :base(name)
        {

        }

        public override CakeBase Copy()
        {
            CakeBase cb = new FruitCake(name);
            return cb;
        }

        public override List<CakeBase> CreateCake()
        {
            List<CakeBase> temp = new List<CakeBase>();
            temp.Add(this);
            return temp;
        }
    }
}
