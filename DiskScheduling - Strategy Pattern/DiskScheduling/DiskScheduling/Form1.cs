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
        private const int NUMBER_OF_RANDOM_REQUESTS = 15;
        private OperatingSystem os;
        private HardDisk hd;
        private Random rng;
        public Form1()
        {
            InitializeComponent();
            rng = new Random();
            hd = new HardDisk();
            os = new OperatingSystem(hd);
            // Generate a list of random requests based on set constant.
            GenerateRandomRequests(15);
            foreach(Request r in os.Requests)
            {
                requestedSectorNumbersLbx.Items.Add(r.SectorNumber);
            }
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            // The timer object handles 1 request per tick and also adds one new request at the end.
            removeItemsTimer.Interval = 200;
            removeItemsTimer.Enabled = true;

            ChangeButtonEnabling();
        }

        private void GenerateRandomRequests(int numberOfRandomRequests)
        {
            for (int i = 0; i < numberOfRandomRequests; i++)
            {
                // Random int < 100, lets say it is possible for different processes
                // to request access to the same sector, thus us not checking for uniqueness.
                int number = rng.Next(100);
                for (int j = 0; j < os.Requests.Count; j++)
                {
                    if (os.Requests[j].SectorNumber == number)
                    {
                        number = rng.Next(100);
                        j = 0;
                    }
                }
                Request req = new Request(number);
                os.Requests.Add(req);
            }
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
            int count = os.Requests.Count;
            os.NextDiskTick();
            lblHead.Text = "Head: " + os.Disk.HeadLocation.ToString();
            if(count != os.Requests.Count) //update listbox and add request
            {
                GenerateRandomRequests(1);

                requestedSectorNumbersLbx.Items.Clear();
                foreach(Request r in os.Requests)
                {
                    requestedSectorNumbersLbx.Items.Add(r.SectorNumber);
                }
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            removeItemsTimer.Enabled = false;

            ChangeButtonEnabling();
        }

        private void ChangeButtonEnabling()
        {
            runBtn.Enabled = !runBtn.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
        }
    }
}
