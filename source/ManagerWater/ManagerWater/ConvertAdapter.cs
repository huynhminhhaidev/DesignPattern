using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{
    //Ap adapter pattern
    //Adapter
    class ConvertAdapter: VNDTarget
    {
        public DollarAdaptee dollarAdaptee;

        public ConvertAdapter(DollarAdaptee dollarAdaptee)
        {
            this.dollarAdaptee = dollarAdaptee;
        }

        public float change(float money)
        {
            float dollar = this.dollarAdaptee.VndToDollar(money);
            return dollar;
        }
    }

    //Ap adapter pattern
    //Adaptee
    class DollarAdaptee
    {
        public float VndToDollar(float money)
        {
            return money / 22.0f;
        }
    }

    //Ap adapter pattern
    //Target
    public interface VNDTarget
    {
        float change(float money);
    }
}
