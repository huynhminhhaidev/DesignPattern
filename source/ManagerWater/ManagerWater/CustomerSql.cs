using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ManagerWater
{
    public class CustomerSql: SqlConnect
    {
        public DataTable getCustomer()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Customer.customer_phone, Customer.customer_name, Customer.customer_address, Customer.customer_kind, Customer.cubicmetre_id, CubicMetre.cubicmetre_count FROM Customer, CubicMetre WHERE Customer.cubicmetre_id = CubicMetre.cubicmetre_id", conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable getCustomer1()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT customer_phone, customer_name, customer_address, customer_kind, cubicmetre_id FROM Customer", conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable findByPhone(String phone)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Customer.customer_phone, Customer.customer_name, Customer.customer_address, Customer.customer_kind, Customer.cubicmetre_id, CubicMetre.cubicmetre_count FROM Customer, CubicMetre WHERE Customer.cubicmetre_id = CubicMetre.cubicmetre_id AND Customer.customer_phone = '"+ phone +"'", conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable findByName(String name)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Customer.customer_phone, Customer.customer_name, Customer.customer_address, Customer.customer_kind, Customer.cubicmetre_id, CubicMetre.cubicmetre_count FROM Customer, CubicMetre WHERE Customer.cubicmetre_id = CubicMetre.cubicmetre_id AND Customer.customer_name = '" + name + "'", conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public bool hasCustomer(String phone, String name)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE customer_phone = '" + phone + "'", conn);

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            finally
            {
                conn.Close();
            }

        }
        public bool hasCustomer1(String phone, String pass)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE customer_phone = '" + phone + "' AND customer_pass = '" + pass + "'", conn);

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                conn.Close();
            }

        }

        public bool addCustomer(Customers customer)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Customer(customer_phone,customer_name,customer_address,customer_kind,customer_pass, cubicmetre_id) VALUES ('" + customer.Customer_phone + "','" + customer.Customer_name + "','" + customer.Customer_address + "','" + customer.Customer_kind + "','" + customer.Customer_password + "','" + customer.CubicMetre_ID + "')", conn);
            
                if (cmd.ExecuteNonQuery() > 0) { return true; }
                else { return false; }
            }
            finally
            {
                conn.Close();
            }


        }

        public Customers findCustomer(String phone)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE customer_phone = '" + phone + "'", conn);

                SqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    r.Read();

                    int cubicmetre_id = 0;
                    if (!r.IsDBNull(5))
                    {
                        cubicmetre_id = int.Parse(r[5].ToString());
                    }
                    return new Customers(r[0].ToString(), r[1].ToString(), r[2].ToString(), r[3].ToString(), r[4].ToString(), int.Parse(r[5].ToString()));

                }
                else
                {
                    return new Customers();
                }
            }
            finally
            {
                conn.Close();
            }
            return new Customers();
        }

        public bool changeIDCubicMetre(int cubicmetre_id, string phone)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET cubicmetre_id = '"+ cubicmetre_id +"' WHERE customer_phone = '"+ phone +"'", conn);
                
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    
        public bool deleteCustomer(string phone)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE Customer WHERE customer_phone = '" + phone + "'", conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
