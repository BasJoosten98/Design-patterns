using System;
using System.Collections.Generic;
using System.Text;

namespace DiskScheduling
{
	public class Request
	{
        private int sectorNumber;
		public int SectorNumber
		{
			get
			{
                return sectorNumber;
			}
		}

		public Request(int SectorNumber)
		{
            sectorNumber = SectorNumber;
		}
	}
}
