using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap template method
    //ConcreteClass
    class Calculator_Hongheo : CalculatorTemplate
    {
        public Calculator_Hongheo(string phone) : base(phone){ }
        protected override float Calculator(float counter)
        {
            float cost = WaterCompany.getInstance().Water_HongheoCost;

            if (counter <= 10)
            {
                //cost 3.600f
                return counter * cost;
            }
            else if (counter > 10 && counter <= 20)
            {
                return counter * (cost + 0.9f);
            }
            else if (counter > 20 && counter <= 30)
            {
                return counter * (cost + 2.0f);
            }
            else
            {
                return counter * (cost + 3.1f);
            }
        }
    }
}
