using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adapter;

namespace AdapterForm
{
    public partial class Form1 : Form
    {
        private IEngine myEngine;
        public Form1()
        {
            InitializeComponent();
            gbTestEngine.Enabled = false;
        }

        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            if (!myEngine.IsEngineOn())
            {
                btnPowerOn.Text = "Power Off";
                lblPower.Text = "Engine Power: On";
                myEngine.PowerOn();
            }
            else
            {
                btnPowerOn.Text = "Power On";
                lblPower.Text = "Engine Power: Off";
                myEngine.PowerOff();
            }
        }

        private void btnCreateEngine_Click(object sender, EventArgs e)
        {
            int gas = int.Parse(tbGas.Text);
            int brake = int.Parse(tbBrake.Text);

            myEngine = new Engine(gas, brake);

            gbTestEngine.Enabled = true;
            lblSpeed.Text = "Current Speed: 0";
            lblPower.Text = "Engine Power: Off";
        }

        private void btnSpeedUp_Click(object sender, EventArgs e)
        {
            myEngine.SpeedUp();
            lblSpeed.Text = "Current Speed: " + myEngine.GetCurrentSpeed();
        }

        private void btnSlowDown_Click(object sender, EventArgs e)
        {
            myEngine.SlowDown();
            lblSpeed.Text = "Current Speed: " + myEngine.GetCurrentSpeed();
        }
    }
}
