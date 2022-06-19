using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    public class WaterCompany
    {
        //Thông tin công ty nước
        public string Company_name;
        public string Company_address;
        public string Company_phone;

        // Giá nước
        public float Water_HogiadinhCost = 5.973f;
        public float Water_HongheoCost = 3.6f;
        public float Water_DoanhnghiepCost = 9.955f;

        //Ham get set
        public string company_name { get; set; }
        public string company_address { get; set; }
        public string conpany_phone { get; set; }

        //Áp dụng singleton(Vì app này sử dụng duy nhất cho 1 công ty)
        private static WaterCompany instance;

        private WaterCompany() { }

        public static WaterCompany getInstance()
        {
            if (instance == null)
            {
                instance = new WaterCompany();
            }
            return instance;
        }
    }
}
