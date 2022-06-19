using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap command pattern
    //ConcreteCommand

    public class ICommand_VoiSen: ICommand
    {
        private Device_VoiSen voiSen;

        public string getName()
        {
            return "VoiSen";
        }

        public ICommand_VoiSen(Device_VoiSen voiSen)
        {
            this.voiSen = voiSen;
        }
        public void turnOff()
        {
            voiSen.turnOff();
        }

        public void turnOn()
        {
            voiSen.turnOn();
        }
    }
}
