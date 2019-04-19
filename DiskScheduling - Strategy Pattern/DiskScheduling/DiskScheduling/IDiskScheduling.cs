using System;
using System.Collections.Generic;
using System.Text;

namespace DiskScheduling
{
	public interface IDiskScheduling
	{
		int HandleRequest(List<Request> requests, int diskHeadLocation);
	}
}
