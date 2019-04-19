using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskScheduling
{
    public partial class Form1 : Form
    {
        private Random rng;
        private const int NUMBER_OF_RANDOM_REQUESTS = 15;
        // Ints will be of request type.
        private List<Request> myRequests;
        private OperatingSystem os;
        private HardDisk hd;
        public Form1()
        {
            InitializeComponent();
            rng = new Random();
            hd = new HardDisk();
            os = new OperatingSystem(hd);
            // Generate a list of random requests based on set constant.
            myRequests = GenerateRandomRequests(NUMBER_OF_RANDOM_REQUESTS);
            foreach(Request r in myRequests)
            {
                os.AddRequest(r);
            }

            foreach(Request r in os.Requests)
            {
                listBox1.Items.Add(r.SectorNumber);
            }
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            // The timer object handles 1 request per tick and also adds one new request at the end.
            removeItemsTimer.Interval = 200;
            removeItemsTimer.Enabled = true;
        }

        private List<Request> GenerateRandomRequests(int numberOfRandomRequests)
        {
            List<Request> tempList = new List<Request>();
            for (int i = 0; i < numberOfRandomRequests; i++)
            {
                // Random int < 100, lets say it is possible for different processes
                // to request access to the same sector, thus us not checking for uniqueness.
                Request req = new Request(rng.Next(100));
                tempList.Add(req);
            }
            return tempList;
        }

        private void rbScan_CheckedChanged(object sender, EventArgs e)
        {
            os.DiskschedulingMethod = new Scan();
        }

        private void rbShortestSeekTimeFirst_CheckedChanged(object sender, EventArgs e)
        {
            os.DiskschedulingMethod = new ShortestSeekTimeFirst();
        }

        private void rbFirstComeFirstServe_CheckedChanged(object sender, EventArgs e)
        {
            os.DiskschedulingMethod = new FirstComeFirstServe();
        }

        private void removeItemsTimer_Tick(object sender, EventArgs e)
        {
            os.nextDiskTick();
        }
    }
}
