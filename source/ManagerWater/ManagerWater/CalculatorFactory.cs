using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Tao concreteClass cho CalcullatorTemplate
    class CalculatorFactory
    {
        public CalculatorFactory(){ }
        public static CalculatorTemplate getCalculatorTemplate(string kind, string phone)
        {
            if (kind == "Ho gia dinh")
            {
                return new Calculator_Hogiadinh(phone);
            }
            else if (kind == "Ho ngheo")
            {
                return new Calculator_Hongheo(phone);
            }
            else
            {
                return new Calculator_Doanhnghiep(phone);
            }
        }
    }
}
