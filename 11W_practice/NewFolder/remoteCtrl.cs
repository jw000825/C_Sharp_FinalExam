using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11W_practice.NewFolder
{
    internal class remoteCtrl
    {
        int isSelected;
        Icontrol[] myControl;

        public remoteCtrl(Icontrol control)
        {
            isSelected = 0;
            myControl = new Icontrol[5];
            this.myControl[0] = control;
        }
        public void Change(int no)
        {
            isSelected = no;
        }
        public void Append(Icontrol myControl, int no)
        {
            isSelected = no;
            this.myControl[isSelected] = myControl;
        }
        public void PushOpen()
        {
            myControl[isSelected].Active();
        }
        public void PushClose()
        {
            myControl[isSelected].Deactive();
        }
    }
}
