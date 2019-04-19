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

        public void nextDiskTick()
        {
            int amountOfRequests = requests.Count;
            int diskMovement = diskschedulingMethod.HandleRequest(requests, disk.HeadLocation);
            disk.HeadLocation += diskMovement;

            if(amountOfRequests != requests.Count) //Request has been accomplished
            {
            //add new request
            Random rng = new Random();
            int number = rng.Next(100);                  
            for (int j = 0; j < requests.Count; j++)
            {
                if (requests[j].SectorNumber == number)
                {
                    number = rng.Next(100);
                    j = 0;
                }
            }
            Request req = new Request(number);
            requests.Add(req);
                
            }
        }
	}
}
