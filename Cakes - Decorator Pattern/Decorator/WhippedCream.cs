using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public class WhippedCream : Cream
	{
        public WhippedCream(string name)
            :base(name)
        {

        }
        public override CakeBase Copy()
        {
            CakeBase cb = new WhippedCream(name);
            if (NextBase != null)
            {
                ((ToppingBase)cb).NextBase = NextBase.Copy();
            }
            return cb;
        }
    }
}
