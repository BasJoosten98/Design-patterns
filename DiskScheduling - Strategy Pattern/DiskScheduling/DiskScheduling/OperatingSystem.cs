using System;
using System.Collections.Generic;
using System.Text;

namespace DiskScheduling
{
	public class OperatingSystem
	{
        private IDiskScheduling diskschedulingMethod;
        private HardDisk disk;
        private List<Request> requests;
		public IDiskScheduling DiskschedulingMethod
		{
			get
			{
                return diskschedulingMethod;
			}
			set
			{
                diskschedulingMethod = value;
			}
		}
        public List<Request> Requests
        {
            get
            {
                return requests;
            }
        }

        public HardDisk Disk
		{
			get
			{
                return disk;
			}
		}

		public void AddRequest(Request request)
		{
            requests.Add(request);
		}

		public OperatingSystem(HardDisk Disk)
		{
            disk = Disk;
            requests = new List<Request>();
		}
	}
}
