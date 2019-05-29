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
            isOn = On;
            lamp = Lamp;
        }
        public void Execute()
        {
            lamp.TurnOnOrOff(isOn);
        }
    }
}
