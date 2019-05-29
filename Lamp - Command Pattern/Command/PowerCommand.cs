using System;
using System.Collections.Generic;
using System.Text;

namespace Week6
{
    public class PowerCommand : ICommand
    {
        private bool isOn;
        private Lamp lamp;

        public PowerCommand(Lamp Lamp, bool On)
        {
            this.isOn = On;
            this.lamp = Lamp;
        }
        public void Execute()
        {
            lamp.TurnOnOrOff(isOn);
        }
    }
}
