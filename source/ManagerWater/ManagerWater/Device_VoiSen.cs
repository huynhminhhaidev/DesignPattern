using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ManagerWater
{
    //AP Factory Pattern
    //Subcalss
    public class Device_VoiSen : Device
    {
        public Device_VoiSen(int cubicMetreID): base("VoiSen", 0.16f, cubicMetreID)
        {

        }

        public override void turnOff()
        {
            this.stop();
        }

        public override void turnOn()
        {
            this.use();
        }
    }
}
