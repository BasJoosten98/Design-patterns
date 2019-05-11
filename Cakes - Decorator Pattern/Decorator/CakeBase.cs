using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public abstract class CakeBase
	{
		protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        public CakeBase(string name)
        {
            this.name = name;
        }

        public abstract List<CakeBase> CreateCake();
        public abstract CakeBase Copy();

		
	}
}
