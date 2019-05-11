using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public class ChocoCream : Cream
	{
        public ChocoCream(string name)
            :base(name)
        {

        }

        public override CakeBase Copy()
        {
            CakeBase cb = new ChocoCream(name);
            if (NextBase != null)
            {
                ((ToppingBase)cb).NextBase = NextBase.Copy();
            }
            return cb;
        }
    }
}
