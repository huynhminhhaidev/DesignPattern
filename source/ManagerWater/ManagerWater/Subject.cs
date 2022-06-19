using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    //Ap observer pattern
    //subject class
    public interface Subject
    {
        void add(Observer observer);
        void remove(Observer observer);
        void notifyAllObserver();
    }

    //Ap obervser pattern
    //Observer class
    public abstract class Observer
    {
        public string phone;
        public Observer(string phone)
        {
            this.phone = phone;
        }

        public string PhoneCustomer { get; set; }
        public abstract void update(string untit, float costPay, float costUsed, float costWater);
    }

    //Ap observer pattern
    //ConcreteSubject
    public class WaterCompanyObserver : Subject
    {
        public ArrayList observers =  new ArrayList();
        public string unit;
        public static WaterCompanyObserver companyObserver = new WaterCompanyObserver();

        public static WaterCompanyObserver getWaterCompanyObserver()
        {
            return companyObserver;
        }

        public void notifyAllObserver()
        {
            CustomerSql customerSql = new CustomerSql();
            CubicMetre cubicMetre = new CubicMetre();

            for (int i = 0; i < observers.Count; ++i)
            {
                Observer observer = (Observer)observers[i];

                Customers customer = customerSql.findCustomer(observer.phone);
                CalculatorTemplate calculatorTemplate = CalculatorFactory.getCalculatorTemplate(customer.Customer_kind, customer.Customer_phone);

                float costWater;

                if (customer.Customer_kind == "Ho gia dinh")
                {
                    costWater = WaterCompany.getInstance().Water_HogiadinhCost;
                }
                else if (customer.Customer_kind == "Ho ngheo")
                {
                    costWater = WaterCompany.getInstance().Water_HongheoCost;
                }
                else
                {
                    costWater = WaterCompany.getInstance().Water_DoanhnghiepCost;
                }

                CubicMetre c = cubicMetre.findCubicMetre(customer.CubicMetre_ID);

                observer.update(this.unit, calculatorTemplate.Pay(), c.CubicMetre_count, costWater);
            }
        }

        public void add(Observer observer)
        {
            observers.Add(observer);
        }

        public void remove(Observer observer)
        {
            int i = observers.IndexOf(observer);
            if (i != -1)
            {
                observers.RemoveAt(i);
            }
        }
    }

    //Ap observer pattern
    //ConcreteObserver
    public class CostDisplay : Observer
    {
        public Subject subject1;
        public float costPay;
        public Label lb_Pay;
        public string unit;
        public Label lb_Used;
        public Label lb_costWater;
        public float costUsed;
        public float costWater;

        public CostDisplay(Subject subject, float costPay, string phone, Label lb_Pay, Label lb_Used, Label lb_costWater): base(phone)
        {
            subject1 = subject;
            this.costPay = costPay;
            this.lb_Pay = lb_Pay;
            this.lb_Used = lb_Used;
            this.lb_costWater = lb_costWater;
            subject.add(this);
        }

        public override void update(string unit, float costPay, float costUsed, float costWater)
        {
            this.unit = unit;
            this.costPay = costPay;
            this.costUsed = costUsed;
            this.costWater = costWater;
            display();
        }

        public void display()
        {
            lb_Pay.Text = string.Format("{0:0.000}", costPay);
            lb_Used.Text = costUsed.ToString() + " m3";
            lb_costWater.Text = costWater.ToString() + " VND/m3";
        }
    }
}
