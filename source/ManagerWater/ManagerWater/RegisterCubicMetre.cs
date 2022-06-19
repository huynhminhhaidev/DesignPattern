using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    public partial class RegisterCubicMetre : Form
    {

        private CubicMetre cubicMetre = new CubicMetre();
        private Customers customers = new Customers();

        public RegisterCubicMetre()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CubicMetre cubicMetre1 = new CubicMetre(0);
            bool b = cubicMetre.addCubicMetre(cubicMetre1);
            //Neu them thanh cong thi load lai gridview
            if(b == true)
            {
                dataGridView2.DataSource = cubicMetre.getCubicMetre();
            }
        }

        private void RegisterCubicMetre_Load(object sender, EventArgs e)
        {
            //nut delete false khi chua chon customer va dong ho
            btn_DeleteCubicMetre.Enabled = false;
            btn_deleteCustomer.Enabled = false;
            btn_cancel.Enabled = false;

            //Dem data vao gridview
            dataGridView2.DataSource = cubicMetre.getCubicMetre();
            dataGridView1.DataSource = customers.getCustomer1();

            //Kich thuoc o^ trong gridview
            dataGridView1.Columns[0].Width = (int)150;
            dataGridView1.Columns[1].Width = (int)160;
            dataGridView1.Columns[2].Width = (int)200;
            dataGridView1.Columns[3].Width = (int)110;
            dataGridView1.Columns[4].Width = (int)120;
            //Kich thuoc o^ trong gridview
            dataGridView2.Columns[0].Width = (int)110;
            dataGridView2.Columns[1].Width = (int)160;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Forcus o trong gridview => enabled nut xoa
            btn_DeleteCubicMetre.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Forcus o trong gridview => enabled nut xoa
            btn_DeleteCubicMetre.Enabled = true;
            displayCubicMetre();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_deleteCustomer.Enabled = true;
            btn_cancel.Enabled = true;
            displayPhoneCustomer();
        }

        private void btn_DeleteCubicMetre_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView2.CurrentRow;

            if(dataGridViewRow != null)
            {
                //Lay gia tri cubicmetre id tu row da click
                int id = int.Parse(dataGridViewRow.Cells[0].Value.ToString());

                //Confirm messagebox
                string message = "Bạn muốn xóa đồng hồ " + id + " không?";
                string title = "Xóa đồng hồ";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if(result == DialogResult.Yes)
                {
                    bool b = cubicMetre.deleteCubicMetre(id);
                    //Xoa thanh cong thi` load lai gridview
                    if(b == true)
                    {
                        dataGridView2.DataSource = cubicMetre.getCubicMetre();
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Lay sdt va id dong ho tu lable
            string phone = lb_phone.Text;
            string id = lb_cubicMetreID.Text;

            string message = "Bạn muốn đăng ký đồng hồ "+ id +" cho người dùng " + phone + " không?";
            string title = "Đăng ký đồng hồ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                bool b = customers.changeIDCubicMetre(int.Parse(id), phone);
                //Neu dang ky thanh cong thi load lai gridview
                if (b == true)
                {
                    dataGridView1.DataSource = customers.getCustomer1();
                }
            }
        }

        private void displayPhoneCustomer()
        {
            DataGridViewRow d = dataGridView1.CurrentRow;
            //Hien thi sdt len lable phone
            if (d != null)
            {
                lb_phone.Text = d.Cells[0].Value.ToString();
            }
        }

        private void displayCubicMetre()
        {
            DataGridViewRow d = dataGridView2.CurrentRow;
            //hien thi id dong ho len lable cubicMetreid
            if (d != null)
            {
                lb_cubicMetreID.Text = d.Cells[0].Value.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
            this.Hide();
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;


            if (dataGridViewRow != null)
            {
                //Lay gia tri customer phone tu row da click
                string phone = dataGridViewRow.Cells[0].Value.ToString();

                //Confirm messagebox
                string message = "Bạn muốn xóa người dùng "+ phone +" không?";
                string title = "Xóa người dùng";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    bool b = customers.deleteCustomer(phone);
                    //Xoa thanh cong thi` load lai gridview
                    if (b == true)
                    {
                        dataGridView1.DataSource = customers.getCustomer1();
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //Lay sdt
            string phone = lb_phone.Text;

            string message = "Bạn muốn hủy đăng ký đồng hồ cho người dùng "+ phone +" không?";
            string title = "Hủy đăng ký đồng hồ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                bool b = customers.changeIDCubicMetre(0, phone);
                //Neu dang ky thanh cong thi load lai gridview
                if (b == true)
                {
                    dataGridView1.DataSource = customers.getCustomer1();
                }
            }
        }
    }
}
