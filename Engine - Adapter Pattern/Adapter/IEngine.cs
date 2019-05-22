using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
	public interface IEngine
	{
		void PowerOn();

		void PowerOff();

		int GetCurrentSpeed();

        bool IsEngineOn();

		void SpeedUp();

		void SlowDown();
	}
}
