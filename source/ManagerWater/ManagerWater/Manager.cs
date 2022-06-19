using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    public partial class Manager : Form
    {
        private Customers customers = new Customers();

        WaterCompanyObserver waterCompanyObserver = WaterCompanyObserver.getWaterCompanyObserver();
        public Manager()
        {
            InitializeComponent();
        }

        private void CustomerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            CustomerGridView.DataSource = customers.getCustomer();
            CustomerGridView.Columns[0].Width = (int)200;
            CustomerGridView.Columns[1].Width = (int)180;
            CustomerGridView.Columns[2].Width = (int)220;
            CustomerGridView.Columns[3].Width = (int)180;
            CustomerGridView.Columns[4].Width = (int)180;
            CustomerGridView.Columns[5].Width = (int)180;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCubicMetre_Click(object sender, EventArgs e)
        {
            RegisterCubicMetre registerCubicMetre = new RegisterCubicMetre();
            registerCubicMetre.Show();
            this.Hide();
        }

        private void btnRegisterCubicMetre_Click(object sender, EventArgs e)
        {

        }

        private void đăngKýCấpNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void inputPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_findPhone_Click(object sender, EventArgs e)
        {
            string phone = inputPhone.Text.ToString();

            //Kiem tra hop le cua phone
            PhoneValidation phoneValidation = new PhoneValidation(phone);

            //K nhap phone thi` tai toan` bo data
            if (phone.Length == 0)
            {
                CustomerGridView.DataSource = customers.getCustomer();
            }

            if (phoneValidation.validate())
            {
                //Tai data len gridview
                CustomerGridView.DataSource = customers.findByPhone(phone);
            }
            else
            {
                MessageBox.Show("Số điện thoại bạn tìm không hợp lệ");
            }
            
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_findName_Click(object sender, EventArgs e)
        {
            string name = inputName.Text.ToString();

            //K nhap name thi` tai toan` bo data
            if (name.Length == 0)
            {
                CustomerGridView.DataSource = customers.getCustomer();
            }
            else
            {
                CustomerGridView.DataSource = customers.findByName(name);
            }

        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            waterCompanyObserver.notifyAllObserver();
        }
    }
}
