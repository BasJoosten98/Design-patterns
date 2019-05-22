using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
	public class OEngine
	{
		private int speed;
		private int brakePower;
		private int gasPower;

        public OEngine(int GasPower, int BrakePower)
        {
            brakePower = BrakePower;
            gasPower = GasPower;
            speed = 0;
        }
		public void Gas()
		{
            speed += gasPower;
		}

		public void Brake()
		{
            speed -= brakePower;
            if(speed < 0) { speed = 0; }
		}

		public int GetSpeed()
		{
            return speed;
		}
	}
}
