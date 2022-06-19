using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    //Ap factory pattern
    //Factory class
    public class DeviceFactory
    {
        public enum DeviceType
        {
            VoiSen,
            VoiNuocThuong
        }

        private DeviceFactory(){ }

        public static Device getDevice1(DeviceType type, int cubicmetre_id)
        {
            if (type == DeviceType.VoiSen)
            {
                return new Device_VoiSen(cubicmetre_id);
            }
            else if(type == DeviceType.VoiNuocThuong)
            {
                return new Device_VoiNuocThuong(cubicmetre_id);
            }
            else
            {
                return null;
            }
        }
    }
}
