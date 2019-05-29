using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week6;

namespace CommandForm
{
    public partial class Form1 : Form
    {
        private Lamp lamp1;
        private Lamp lamp2;
        private Caller cal;
        public Form1()
        {
            InitializeComponent();
            picBox1.BackColor = Color.White;
            picBox2.BackColor = Color.White;
            lamp1 = new Lamp(picBox1);
            lamp2 = new Lamp(picBox2);
            cal = new Caller();
            fillListBoxes();
            this.Refresh();
        }

        private void fillListBoxes()
        {
            lbLamps.Items.Add(lamp1);
            lbLamps.Items.Add(lamp2);

            lbActions.Items.Add(Color.Red);
            lbActions.Items.Add(Color.Blue);
            lbActions.Items.Add(Color.Green);
            lbActions.Items.Add(false);
            lbActions.Items.Add(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int indexLamp = lbLamps.SelectedIndex;
            int indexAction = lbActions.SelectedIndex;
            if(indexLamp > -1 && indexAction > -1)
            {
                Lamp l = (Lamp)lbLamps.Items[indexLamp];
                Object o = lbActions.Items[indexAction];

                if(o is bool)
                {
                    PowerCommand pc = new PowerCommand(l, (bool)o);
                    cal.AddAnimation(pc);
                }
                else if(o is Color)
                {
                    AnimationCommand ac = new AnimationCommand(l, (Color)o);
                    cal.AddAnimation(ac);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!cal.CallNextAnimation())
            {
                timer1.Enabled = false;
                MessageBox.Show("Animation ended");
            }
            this.Refresh();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
