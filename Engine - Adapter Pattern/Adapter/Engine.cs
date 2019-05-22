using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
	public class Engine : IEngine
	{
		private OEngine oldEngine;
		private bool engineIsOn;

        public Engine(int GasPower, int BrakePower)
        {
            oldEngine = new OEngine(GasPower, BrakePower);
            engineIsOn = false;
        }
        public int GetCurrentSpeed()
        {
           return oldEngine.GetSpeed();
        }

        public bool IsEngineOn()
        {
            return engineIsOn;
        }

        public void PowerOff()
        {
            engineIsOn = false;
        }

        public void PowerOn()
        {
            engineIsOn = true;
        }

        public void SlowDown()
        {
            oldEngine.Brake();
        }

        public void SpeedUp()
        {
            if (engineIsOn)
            {
                oldEngine.Gas();
            }
        }
    }
}
