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
        public Form1()
        {
            InitializeComponent();
            rng = new Random();
            // Generate a list of random requests based on set constant.
            myInts = GenerateRandomRequests(NUMBER_OF_RANDOM_REQUESTS);
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            // The timer object handles 1 request per tick and also adds one new request at the end.
        }

        private List<Request> GenerateRandomRequests(int numberOfRandomRequests)
        {
            for (int i = 0; i < numberOfRandomRequests; i++)
            {
                // Random int < 100, lets say it is possible for different processes
                // to request access to the same sector, thus us not checking for uniqueness.
                rng.Next(100);
            }
        }
    }
}
