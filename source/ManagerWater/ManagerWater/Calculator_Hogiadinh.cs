using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap template method
    //ConcreteClass
    class Calculator_Hogiadinh : CalculatorTemplate
    {
        public Calculator_Hogiadinh(string phone) : base(phone){ }

        protected override float Calculator(float counter)
        {

            float cost = WaterCompany.getInstance().Water_HogiadinhCost;

            if (counter <= 10)
            {
                //cost 5.973f
                return counter * cost;
            }
            else if (counter > 10 && counter <= 20)
            {
                return counter * (cost + 1.079f);
            }
            else if (counter > 20 && counter <= 30)
            {
                return counter * (cost + 2.696f);
            }
            else
            {
                return counter * (cost + 9.956f);
            }
        }
    }
}
