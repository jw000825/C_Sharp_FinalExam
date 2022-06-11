using System;
using System.IO;

namespace _10W_practice
{
    public class Program
    {
        static void Main()
        {
            myFan myfan1 = new myFan(10);
            myFan myfan2 = new myFan(20, true);

            myfan1.powerOn();
            myfan2.powerOn();

            myfan1.swing(true, true);
            myfan2.swing(true, true);

            myfan1.activeSpecialFunc(myFan.SF_state.step1);
        }
    }
}