using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerWater
{
    public partial class Login : Form
    {
        private Customers customers = new Customers();
        public Login()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            messageError.ForeColor = Color.Red;
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String phone = phonenumber.Text.Trim();
            String pass = password.Text.Trim();

            //MessageBox.Show(phone, pass);

            if (phone == "")
            {
                messageError.Text = "Bạn chưa điền số điện thoại";
            }
            else if(pass == "")
            {
                messageError.Text = "Bạn chưa điền mật khẩu";
            }
            else
            {
                if (phone == "admin" && pass == "admin")
                {
                    Manager m = new Manager();
                    m.Show();
                    //this.Hide();
                    phonenumber.Text = "";
                    password.Text = "";
                }
                else
                {
                    PhoneValidation p = new PhoneValidation(phone);
                    if (p.validate())
                    {
                        bool result = customers.hasCustomer1(phone, pass);
                        if (result == true)
                        {
                            Program.phone = phone;
                            Customer c = new Customer();
                            c.Show();
                            //this.Hide();
                            phonenumber.Text = "";
                            password.Text = "";
                        }
                        else
                        {
                            password.Text = "";
                            messageError.Text = "Số điện thoại hoặc mật khẩu sai";
                        }
                    }
                    else
                    {
                        messageError.Text = "Số điện thoại không hợp lệ";
                    }
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
