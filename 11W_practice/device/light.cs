using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11W_practice.device
{
    internal class light
    {
        private bool isOn;

        public light(bool OnOFF = false)
        {
            this.isOn = OnOFF;
        }

        public void On()
        {
            Console.WriteLine("Light On");
        }
        public void Off()
        {
            Console.WriteLine("LIght Off");
        }
        public void Active()
        {
            this.On();
        }
        public void Deactive()
        {
            this.Off();
        }
    }
}
