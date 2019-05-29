using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week6
{
	public class Lamp
	{
		private PictureBox picBox;
        private int id;
        private static int idCounter = 1;

        public Lamp(PictureBox box)
        {
            picBox = box;
            id = idCounter;
            idCounter++;
        }
		public void SetColor(Color color)
		{
            if (picBox.BackColor != Color.Black)
            {
                picBox.BackColor = color;
            }
		}
        public void TurnOnOrOff(bool on)
        {
            if (on)
            {
                picBox.BackColor = Color.White;
            }
            else
            {
                picBox.BackColor = Color.Black;
            }
        }

        public override string ToString()
        {
            return "Lamp " + id;
        }
    }
}
