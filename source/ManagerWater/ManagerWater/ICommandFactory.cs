using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap command pattern
    //
    class ICommandFactory
    {
        public ICommand createCommand(String type)
        {
            Customers customers = new Customers();
            Customers customer = customers.findCustomer(Program.phone);

            //Voisen
            Device_VoiSen voiSen;
            voiSen = (Device_VoiSen)Device.getDevice1(DeviceFactory.DeviceType.VoiSen, customer.CubicMetre_ID);

            //Voi nuoc thuong
            Device_VoiNuocThuong voiNuocThuong;
            voiNuocThuong = (Device_VoiNuocThuong)Device.getDevice1(DeviceFactory.DeviceType.VoiNuocThuong, customer.CubicMetre_ID);

            if (type == "VoiSen")
            {
                return new ICommand_VoiSen(voiSen);
            }
            else
            {
                return new ICommand_VoiNuocThuong(voiNuocThuong);
            }
        }
    }
}
