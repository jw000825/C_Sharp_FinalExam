using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _11W_practice.device
{
    internal class autoDoor : Icontrol
    {
        private int isState;
        public enum DoorState { closed, opened, opening };
        private DoorState State;
        private System.Timers.Timer autoClosetimer;

        public autoDoor(DoorState initState)
        {
            this.State = initState;
            autoClosetimer = new System.Timers.Timer(4000);
            autoClosetimer.Elapsed += OnTImeEvent;
            autoClosetimer.AutoReset = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($" >>> auto closed timer done {e.SignalTime}");
            this.Close();
        }
    }
}
