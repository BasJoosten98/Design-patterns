using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Week6
{
	public class AnimationCommand : ICommand
    {
		private Lamp lamp;
		private Color color;

        public AnimationCommand(Lamp Lamp, Color Color)
        {
            this.lamp = Lamp;
            this.color = Color;
        }

        public void Execute()
        {
            lamp.SetColor(color);
        }
    }
}
