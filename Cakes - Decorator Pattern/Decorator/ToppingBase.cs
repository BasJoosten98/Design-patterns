using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public abstract class ToppingBase : CakeBase
	{
        public CakeBase NextBase;
        public ToppingBase(string name)
            :base(name)
        {

        }

        public override List<CakeBase> CreateCake()
        {
            List<CakeBase> temp = NextBase.CreateCake();
            temp.Add(this);
            return temp;
        }
    }
}
