
namespace ManagerWater
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.messageError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(94, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(38, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(63, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu: ";
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(152, 127);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(204, 27);
            this.phonenumber.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(152, 207);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(204, 27);
            this.password.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(152, 305);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(97, 36);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkRegister.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkRegister.Location = new System.Drawing.Point(290, 277);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(66, 20);
            this.linkRegister.TabIndex = 6;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Đăng ký";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // messageError
            // 
            this.messageError.AutoSize = true;
            this.messageError.Location = new System.Drawing.Point(152, 249);
            this.messageError.Name = "messageError";
            this.messageError.Size = new System.Drawing.Size(0, 20);
            this.messageError.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(342, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messageError);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Label messageError;
        private System.Windows.Forms.Panel panel1;
    }
}

