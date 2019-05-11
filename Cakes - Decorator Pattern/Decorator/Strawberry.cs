using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public class Strawberry : Fruit
	{
        public Strawberry(string name)
            :base(name)
        {

        }
        public override CakeBase Copy()
        {
            CakeBase cb = new Strawberry(name);
            if (NextBase != null)
            {
                ((ToppingBase)cb).NextBase = NextBase.Copy();
            }
            return cb;
        }
    }
}
