using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap template method
    //ConcreteClass
    class Calculator_Doanhnghiep: CalculatorTemplate
    {
        public Calculator_Doanhnghiep(string phone) : base(phone){ }
        protected override float Calculator(float counter)
        {
            float cost = WaterCompany.getInstance().Water_DoanhnghiepCost;
            //cost 9.955f
            return counter * cost;
        }
    }
}
