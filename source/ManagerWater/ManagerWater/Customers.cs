using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ManagerWater
{
    public class Customers
    {
        //Customer SQL
        private CustomerSql customerSql = new CustomerSql();

        //Thông tin khách hàng
        //public int Customer_id;
        public string Customer_name;
        public string Customer_phone;
        public string Customer_address;
        public string Customer_kind;
        public string Customer_password;
        public int CubicMetre_ID;

        //Hàm get set 
        //public int customer_id { get; set; }
        public string customer_name { get; set; }
        public int customer_phone { get; set; }
        public string customer_address { get; set; }
        public string customer_kind { get; set; }
        public string customer_password { get; set; }
        public int cubicMetre_id { get; set; }

        public Customers()
        {

        }

        public Customers(string Customer_phone,string Customer_name, string Customer_address, string Customer_kind, string Customer_password)
        {
            this.Customer_name = Customer_name;
            this.Customer_phone = Customer_phone;
            this.Customer_address = Customer_address;
            this.Customer_kind = Customer_kind;
            this.Customer_password = Customer_password;
        }

        public Customers(string Customer_phone, string Customer_name, string Customer_address, string Customer_kind, string Customer_password,int CubicMetre_ID)
        {
            this.Customer_name = Customer_name;
            this.Customer_phone = Customer_phone;
            this.Customer_address = Customer_address;
            this.Customer_kind = Customer_kind;
            this.Customer_password = Customer_password;
            this.CubicMetre_ID = CubicMetre_ID;
        }


        //Phan xu ly SQL
        public DataTable getCustomer()
        {
            return customerSql.getCustomer();
        }

        public DataTable getCustomer1()
        {
            return customerSql.getCustomer1();
        }

        public bool hasCustomer(String phone, String name)
        {
            return customerSql.hasCustomer(phone, name);
        }
        public bool hasCustomer1(String phone, String pass)
        {
            return customerSql.hasCustomer1(phone, pass);
        }

        public bool addCustomer(Customers customer)
        {
            return customerSql.addCustomer(customer);
        }

        public Customers findCustomer(String phone)
        {
            return customerSql.findCustomer(phone);
        }

        public bool changeIDCubicMetre(int cubicmetre_id, string phone)
        {
            return customerSql.changeIDCubicMetre(cubicmetre_id, phone);
        }

        public DataTable findByPhone(String phone)
        {
            return customerSql.findByPhone(phone);
        }

        public DataTable findByName(String name)
        {
            return customerSql.findByName(name);
        }

        public bool deleteCustomer(String phone)
        {
            return customerSql.deleteCustomer(phone);
        }
    }
}
