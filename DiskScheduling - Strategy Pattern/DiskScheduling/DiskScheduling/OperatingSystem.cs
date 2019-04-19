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
        private Random rng;
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
            rng = new Random();

            //Create random request list
            for (int i = 0; i < 15; i++)
            {
                // Random int < 100, lets say it is possible for different processes
                // to request access to the same sector, thus us not checking for uniqueness.
                int number = rng.Next(100);
                for (int j = 0; j < requests.Count; j++)
                {
                    if (requests[i].SectorNumber == number)
                    {
                        number = rng.Next(100);
                        j = 0;
                    }
                }
                Request req = new Request(number);
                requests.Add(req);
            }
        }

        public void nextDiskTick()
        {
            int amountOfRequests = requests.Count;
            int diskMovement = diskschedulingMethod.HandleRequest(requests, disk.HeadLocation);
            disk.HeadLocation += diskMovement;

            if(amountOfRequests != requests.Count) //Request has been accomplished
            {
            //add new request
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
