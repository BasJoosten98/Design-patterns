using System;
using System.Collections.Generic;
using System.Text;

namespace DiskScheduling
{
	public class FirstComeFirstServe : IDiskScheduling
	{
        public int HandleRequest(List<Request> requests, int diskHeadLocation)
        {
            int movement = 0;
            if (requests.Count > 0)
            {
                Request firstRequest = requests[0];

                if (firstRequest.SectorNumber < diskHeadLocation)
                {
                    movement = -1;
                }
                else if (firstRequest.SectorNumber == diskHeadLocation)
                {
                    requests.Remove(firstRequest);
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
