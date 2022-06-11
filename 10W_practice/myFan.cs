using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10W_practice
{
    internal class myFan
    {
        private bool StatusPowerOnOff;
        private int FanSpeed;
        private bool StatusPanSwing;
        private bool StatusTiltSwing;

        public enum SF_state { step0, step1 };
        private SF_state real_state;

        public myFan()
        {
            StatusPowerOnOff = false;
            FanSpeed = 0;
        }

        public myFan(int FanSpeed, bool pwrSatus = false)
        {
            StatusPowerOnOff = pwrSatus;
            this.FanSpeed = FanSpeed;
        }

        public void powerOn()
        {
            Console.WriteLine("Pwer On");
        }

        public void speedUp(int speed)
        {
            Console.WriteLine($"Speed UP {FanSpeed}->{speed}");
            FanSpeed  = speed;
            Console.WriteLine($"Speed UP value:{FanSpeed}");
        }

        public void swing(bool panOn, bool tiltOn)
        {
            this.StatusPanSwing = panOn;
            this.StatusTiltSwing = tiltOn;
            Console.WriteLine($"Swing Status PAN:[{StatusPanSwing}] Tilt[{StatusTiltSwing}]");
        }

        public void activeSpecialFunc(SF_state state)
        {
            this.real_state = state;
            Console.WriteLine($"SpecialFunc state:[{real_state}]");
        }
    }

}
