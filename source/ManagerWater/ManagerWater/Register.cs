using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    public partial class Register : Form
    {

        private Customers customers = new Customers();
        private ValidationContext context = new ValidationContext();

        public Register()
        {
            InitializeComponent();
            kindofcustomer.Items.Add("Ho gia dinh");
            kindofcustomer.Items.Add("Doanh nghiep");
            kindofcustomer.Items.Add("Ho ngheo");
            password.PasswordChar = '*';
        }

        // Reset lại các input
        public void removeInput()
        {
            fullname.Text = "";
            phonenumber.Text = "";
            password.Text = "";
            address.Text = "";
            kindofcustomer.SelectedItem = null;
        }

        //Xu ly nut signup
        private void signup_Click(object sender, EventArgs e)
        {
            string name = fullname.Text;
            string phone = phonenumber.Text;
            string pass = password.Text;
            string add = address.Text;
            string kind;
            int cubicMetreId = 0;

            if (kindofcustomer.SelectedItem == null)
            {
                kind = "";
            }
            else
            {
                kind = kindofcustomer.SelectedItem.ToString();
            }

            if (name == "")
            {
                error_register.ForeColor = Color.Red;
                error_register.Text = "Bạn chưa điền họ và tên";
            }
            else if(phone == "")
            {
                error_register.ForeColor = Color.Red;
                error_register.Text = "Bạn chưa điền số điện thoại";
            }
            else if(pass == "")
            {
                error_register.ForeColor = Color.Red;
                error_register.Text = "Bạn chưa điền mật khẩu";
            }
            else if(add == "")
            {
                error_register.ForeColor = Color.Red;
                error_register.Text = "Bạn chưa điền địa chỉ";
            }
            else if(kind == "")
            {
                error_register.ForeColor = Color.Red;
                error_register.Text = "Bạn chưa chọn loại hình";
            }else if(!context.valid(new PasswordValidation(pass)))
            {
                error_register.ForeColor = Color.Red;
                error_register.Text = "Mật khẩu phải hơn 8 ký tự";
            }
            else if(!context.valid(new FullnameValidation(name)))
            {
                error_register.ForeColor = Color.Red;
                error_register.Text = "Tên không hợp lệ";
            }
            else
            {
                //Kiem tra sdt hop le
                if(context.valid(new PhoneValidation(phone)))
                {
                    //Kiem tra loai hinh hop le
                    if(context.valid(new KindOfCustomerValidation(kind)))
                    {
                        bool check = customers.hasCustomer(phone, name);
                        
                        if(check == true)
                        {
                            error_register.ForeColor = Color.Red;
                            error_register.Text = "Số điện thoại đã đăng ký";
                        }
                        else
                        {
                            Customers c = new Customers(phone, name, add, kind, pass, cubicMetreId);
                            bool r = customers.addCustomer(c);

                            if (r == true)
                            {
                                error_register.ForeColor = Color.Green;
                                error_register.Text = "Đăng ký thành công";
                                removeInput();
                            }
                        }
                    }
                    else if(!context.valid(new KindOfCustomerValidation(kind)))
                    {
                        error_register.ForeColor = Color.Red;
                        error_register.Text = "Loại hình không hợp lệ";
                    }
                }else if(!context.valid(new PhoneValidation(phone)))
                {
                    error_register.ForeColor = Color.Red;
                    error_register.Text = "Số điện thoại không hợp lệ";
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kindofcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
