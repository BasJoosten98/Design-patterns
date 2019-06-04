using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public class Strawberry : Fruit
	{
        public Strawberry(string name, CakeBase Next)
            : base(name, Next)
        {

        }
        public override CakeBase Copy()
        {
            CakeBase cb = new Strawberry(name, NextBase);
            if (NextBase != null)
            {
                ((ToppingBase)cb).NextBase = NextBase.Copy();
            }
            return cb;
        }
    }
}
