using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public class WhippedCream : Cream
	{
        public WhippedCream(string name, CakeBase Next)
            : base(name, Next)
        {

        }
        public override CakeBase Copy()
        {
            CakeBase cb = new WhippedCream(name, NextBase);
            if (NextBase != null)
            {
                ((ToppingBase)cb).NextBase = NextBase.Copy();
            }
            return cb;
        }
    }
}
