using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap command pattern
    //ConcreteCommand
    public class ICommand_VoiNuocThuong: ICommand
    {
        private Device_VoiNuocThuong voiNuocThuong;

        public ICommand_VoiNuocThuong(Device_VoiNuocThuong voiNuocThuong)
        {
            this.voiNuocThuong = voiNuocThuong;
        }

        public string getName()
        {
            return "VoiNuocThuong";
        }

        public void turnOff()
        {
            voiNuocThuong.turnOff();
        }

        public void turnOn()
        {
            voiNuocThuong.turnOn();
        }
    }
}
