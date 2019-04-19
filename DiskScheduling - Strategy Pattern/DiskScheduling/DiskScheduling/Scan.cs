using System;
using System.Collections.Generic;
using System.Text;

namespace DiskScheduling
{
	public class Scan : IDiskScheduling
	{
        bool goingUp = false;
		public int HandleRequest(List<Request> requests, int diskHeadLocation)
        {
            foreach(Request r in requests)
            {
                if(r.SectorNumber == diskHeadLocation)
                {
                    requests.Remove(r);
                    return 0;
                }
            }
			if(diskHeadLocation == 100)
            {
                goingUp = false;
            }
            else if(diskHeadLocation == 0)
            {
                goingUp = true;
            }
            if (goingUp) { return 1; }
            else { return -1; }         
        }
    }
}
