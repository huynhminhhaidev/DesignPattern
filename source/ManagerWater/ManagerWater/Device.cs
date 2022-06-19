using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    //Áp factory method
    //Super Class
    public abstract class Device
    {
        DeviceSql deviceSql = new DeviceSql();

        //Thong tin thiet bi su dung nuoc
        public string Device_name;
        public int cubicmetreID;
        //cong suat
        public float Wattage;


        //Thoi gian su dung nuoc
        public int timeOn = 0;
        public System.Timers.Timer timeout;
        private InterVal interVal = new InterVal();
        

        //Ham get set
        public string device_name { get; set; }
        public int cubicmetreid { get; set; }
        public float wattage { get; set; }
        public int timeon { get; set; }

        //------------

        public Device()
        {

        }

        public Device(string Device_name, float Wattage, int cubicmetreID)
        {
            this.Device_name = Device_name;
            this.Wattage = Wattage;
            this.cubicmetreID = cubicmetreID;
        }

        //Ham on off thiet bi
        public abstract void turnOn();
        public abstract void turnOff();

        //Ham su dung nuoc
        public void use()
        {
            this.timeout = interVal.interval(() =>
            {
                timeOn += 1;
            }, 1000);
        }

        //Ham` stop
        public void stop()
        {
            interVal.removeInterval(timeout);
            CubicMetre cubicMetre = deviceSql.findCubicMetre1(cubicmetreID);

            cubicMetre.CubicMetre_count += (timeOn * Wattage)/1000;
            timeOn = 0;
            deviceSql.addCubicMetreUsed(cubicMetre);
        }

        public static Device getDevice1(DeviceFactory.DeviceType type, int cubicmetre_id)
        {
            return DeviceFactory.getDevice1(type, cubicmetre_id);
        }
    }
}
