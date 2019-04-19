using System;
using System.Collections.Generic;
using System.Text;

namespace DiskScheduling
{
    public class ShortestSeekTimeFirst : IDiskScheduling
    {
        public int HandleRequest(List<Request> requests, int diskHeadLocation)
        {
            int movement = 0;
            if (requests.Count > 0)
            {
                Request closestRequest = requests[0];
                int closestSectorNumber = closestRequest.SectorNumber;
                foreach(Request r in requests)
                {
                    if (Math.Abs(r.SectorNumber - diskHeadLocation) < Math.Abs(closestRequest.SectorNumber - diskHeadLocation))
                    {
                        closestRequest = r;
                        closestSectorNumber = r.SectorNumber;
                    }
                }

                if (closestSectorNumber < diskHeadLocation)
                {
                    movement = -1;
                }
                else if (closestSectorNumber == diskHeadLocation)
                {
                    requests.Remove(closestRequest);
                }
                else
                {
                    movement = 1;
                }
            }
            return movement;
        }
    }
}
