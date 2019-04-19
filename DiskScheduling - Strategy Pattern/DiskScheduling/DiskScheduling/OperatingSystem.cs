using System;
using System.Collections.Generic;
using System.Text;

namespace DiskScheduling
{
	public class OperatingSystem
	{
		public IDiskScheduling DiskschedulingMethod
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public HardDisk Disk
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public void AddRequest(Request request)
		{
			throw new NotImplementedException();
		}

		public OperatingSystem(HardDisk disk)
		{
			throw new NotImplementedException();
		}
	}
}
