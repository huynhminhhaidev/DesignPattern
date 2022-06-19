using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerWater
{

    //Ap template method
    //Abstract class
    //Client cua adapter pattern
    abstract class CalculatorTemplate
    {
        //Khai bao bien
        public string customer_phone;

        //Ham get set
        public Customers Customers { get; set; }
        protected CalculatorTemplate(string phone)
        {
            this.customer_phone = phone;
        }

        //Lay nguoi dung
        protected Customers getCustomer()
        {
            CustomerSql customerSql = new CustomerSql();

            return customerSql.findCustomer(customer_phone);
        }

        //Lay so ký điện mà khách đã sử dung
        protected float getCounter()
        {
            CubicMetreSql cubicMetreSql = new CubicMetreSql();

            CubicMetre cubicMetre = cubicMetreSql.findCubicMetre(Customers.CubicMetre_ID);

            float counter = cubicMetre.CubicMetre_count;

            return counter;
        }

        //Ham abstract
        protected abstract float Calculator(float counter);

        //Ham thuc hien tinh tien
        public float Pay()
        {
            this.Customers = getCustomer();
            float pay = Calculator(getCounter());
            return pay;
        }

    }
}
