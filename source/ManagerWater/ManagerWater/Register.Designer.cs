
namespace ManagerWater
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.kindofcustomer = new System.Windows.Forms.ComboBox();
            this.signup = new System.Windows.Forms.Button();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.error_register = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(122, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(56, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(32, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(17, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ đăng ký: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(59, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại hình: ";
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(146, 115);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(222, 27);
            this.fullname.TabIndex = 5;
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(146, 171);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(222, 27);
            this.phonenumber.TabIndex = 6;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(146, 266);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(222, 27);
            this.address.TabIndex = 7;
            // 
            // kindofcustomer
            // 
            this.kindofcustomer.FormattingEnabled = true;
            this.kindofcustomer.Location = new System.Drawing.Point(146, 313);
            this.kindofcustomer.Name = "kindofcustomer";
            this.kindofcustomer.Size = new System.Drawing.Size(125, 28);
            this.kindofcustomer.TabIndex = 8;
            this.kindofcustomer.SelectedIndexChanged += new System.EventHandler(this.kindofcustomer_SelectedIndexChanged);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.SteelBlue;
            this.signup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signup.Location = new System.Drawing.Point(146, 404);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(104, 35);
            this.signup.TabIndex = 9;
            this.signup.Text = "Đăng ký";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLogin.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLogin.Location = new System.Drawing.Point(286, 376);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(85, 20);
            this.linkLogin.TabIndex = 10;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Đăng nhập";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(60, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mật khẩu: ";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(146, 223);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(222, 27);
            this.password.TabIndex = 12;
            // 
            // error_register
            // 
            this.error_register.AutoSize = true;
            this.error_register.ForeColor = System.Drawing.Color.Red;
            this.error_register.Location = new System.Drawing.Point(146, 354);
            this.error_register.Name = "error_register";
            this.error_register.Size = new System.Drawing.Size(0, 20);
            this.error_register.TabIndex = 13;
            this.error_register.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(321, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 14;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(461, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.error_register);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.kindofcustomer);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.ComboBox kindofcustomer;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label error_register;
        private System.Windows.Forms.Panel panel1;
    }
}