using System;
using System.Collections.Generic;
using System.Text;

namespace DiskScheduling
{
	public class HardDisk
	{
        private int headLocation;
		public int HeadLocation
		{
			get
			{
                return headLocation;
			}
			set
			{
                headLocation = value;
			}
		}

		public HardDisk()
		{
            headLocation = 0;
		}
	}
}
