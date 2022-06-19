using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerWater
{
    public partial class Customer : Form
    {
        ////Khai bao 
        Customers customers = new Customers();
        CubicMetre cubicMetre = new CubicMetre();

        public int cubicMetre_id;

        //Khai bao mang cac command
        ICommand[] commands = new ICommand[6];

        //Gan cac lable vao mang, truy cap thong qua chi so
        private Label[] labels;

        //Tao list button on va off
        List<Button> buttons_on;
        List<Button> buttons_off;

        //
        WaterCompanyObserver waterCompanyObserver = WaterCompanyObserver.getWaterCompanyObserver();

        public Customer()
        {
            InitializeComponent();
            labels = new[] { slot1, slot2, slot3, slot4, slot5, slot6 };

            //Them cac button on va off vao list
            buttons_on = new List<Button>() { btn_on1, btn_on2, btn_on3, btn_on4, btn_on5, btn_on6 };
            buttons_off = new List<Button>() { btn_off1, btn_off2, btn_off3, btn_off4, btn_off5, btn_off6 };
        }

        private void Customer_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < buttons_off.Count; i++)
            {
                buttons_off[i].Enabled = false;
                buttons_on[i].Enabled = false;
            }

            Customers customer = customers.findCustomer(Program.phone);
            this.cubicMetre_id = customer.CubicMetre_ID;

            //Load thong tin len man hinh nguoi dung
            customer_phone.Text = customer.Customer_phone.ToString();
            customer_name.Text = customer.Customer_name.ToString();
            customer_address.Text = customer.Customer_address.ToString();
            customer_kind.Text = customer.Customer_kind.ToString();
            if (customer.CubicMetre_ID.ToString() == "0")
            {
                cubicmetre_id.ForeColor = Color.Red;
                cubicmetre_id.Text = "Chưa đăng ký đồng hồ";
            }
            else
            {
                cubicmetre_id.Text = customer.CubicMetre_ID.ToString();
                CubicMetre c = cubicMetre.findCubicMetre(int.Parse(cubicmetre_id.Text));
                cubicMetre_Used.Text = c.CubicMetre_count.ToString() + " m3";
            }

            //Observer
            CostDisplay costDisplay = new CostDisplay(waterCompanyObserver, 0, customer.Customer_phone, lb_Pay, lb_used, lb_cost);
        }

        private void btn_off1_Click(object sender, EventArgs e)
        {

            var btn = (Button)sender;
            var slot = int.Parse(btn.Text) - 1;
            //Neu nhu da co thiet bi dc gan'
            if (commands[slot] != null)
            {
                commands[slot].turnOff();
                //Doi mau
                labels[slot].BackColor = SystemColors.Control;

                buttons_on[slot].Enabled = true;
                buttons_off[slot].Enabled = false;
            }

            cubicMetre_Used.Text = cubicMetre.findCubicMetre(cubicMetre_id).CubicMetre_count.ToString();
        }

        private void lbl_dangxuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void voiSenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lay vi tri slot
            var item = (ToolStripItem)sender;
            var menu = (ContextMenuStrip)item.Owner;
            var label = (Label)menu.SourceControl;
            var slot = int.Parse(label.Tag.ToString()) - 1;

            //Bam nut Remove
            if (item.Text == "Remove")
            {
                //slot la null
                commands[slot] = null;
                //gan null vao slot do
                label.Text = "";
                //thay doi backcolor control
                label.BackColor = SystemColors.Control;
                // Enable = fasle cho button
                buttons_off[slot].Enabled = false;
                buttons_on[slot].Enabled = false;

                return;
            }

            //Chon thiet bi tren menustrip
            commands[slot] = new ICommandFactory().createCommand(item.Text);
            //Gan ten thiet bi vao slot
            label.Text = commands[slot].getName();
            //Enable cho nut on
            buttons_on[slot].Enabled = true;
        }

        private void btn_on1_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var slot = int.Parse(btn.Text) - 1;
            //Neu nhu da co thiet bi dc gan'
            if (commands[slot] != null)
            {
                commands[slot].turnOn();
                //Doi mau
                labels[slot].BackColor = Color.Gray;

                buttons_off[slot].Enabled = true;
                buttons_on[slot].Enabled = false;
            }
        }

        private void btn_calculator_Payment_Click(object sender, EventArgs e)
        {
            CalculatorFactory calculatorFactory = new CalculatorFactory();

            CustomerSql customerSql = new CustomerSql();

            //Tim customer co sdt la Progam.phone
            Customers customer = customerSql.findCustomer(Program.phone);

            CalculatorTemplate calculatorTemplate = CalculatorFactory.getCalculatorTemplate(customer.Customer_kind, customer.Customer_phone);

            //Làm tròn hai chữ số string.Format("{0:0.00}"
            moneyPay.Text = string.Format("{0:0.000}", calculatorTemplate.Pay()) + " VND";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_convertToDollar_Click(object sender, EventArgs e)
        {
            float money = float.Parse(lb_Pay.Text.ToString());

            //chuyen vnd sang dollar
            VNDTarget vNDTarget = new ConvertAdapter(new DollarAdaptee());
            float moneyConverted = vNDTarget.change(money);
            //Làm tròn 2 chữ số Math.Round
            lb_dollar.Text = Math.Round(moneyConverted, 2) + " $";
        }
    }
}
