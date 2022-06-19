
namespace ManagerWater
{
    partial class RegisterCubicMetre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterCubicMetre));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_CreateCubicMetre = new System.Windows.Forms.Button();
            this.btn_DeleteCubicMetre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_deleteCustomer = new System.Windows.Forms.Button();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_cubicMetreID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(911, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(955, 264);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(310, 296);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellClick);
            // 
            // btn_CreateCubicMetre
            // 
            this.btn_CreateCubicMetre.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_CreateCubicMetre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateCubicMetre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CreateCubicMetre.Location = new System.Drawing.Point(955, 215);
            this.btn_CreateCubicMetre.Name = "btn_CreateCubicMetre";
            this.btn_CreateCubicMetre.Size = new System.Drawing.Size(126, 29);
            this.btn_CreateCubicMetre.TabIndex = 2;
            this.btn_CreateCubicMetre.Text = "Tạo đồng hồ";
            this.btn_CreateCubicMetre.UseVisualStyleBackColor = false;
            this.btn_CreateCubicMetre.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_DeleteCubicMetre
            // 
            this.btn_DeleteCubicMetre.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_DeleteCubicMetre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DeleteCubicMetre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DeleteCubicMetre.Location = new System.Drawing.Point(1155, 215);
            this.btn_DeleteCubicMetre.Name = "btn_DeleteCubicMetre";
            this.btn_DeleteCubicMetre.Size = new System.Drawing.Size(110, 29);
            this.btn_DeleteCubicMetre.TabIndex = 3;
            this.btn_DeleteCubicMetre.Text = "Xóa đồng hồ";
            this.btn_DeleteCubicMetre.UseVisualStyleBackColor = false;
            this.btn_DeleteCubicMetre.Click += new System.EventHandler(this.btn_DeleteCubicMetre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số điện thoại: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID đồng hồ: ";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(113, 83);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(142, 34);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Đăng ký đồng hồ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(1206, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quản lý";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_deleteCustomer
            // 
            this.btn_deleteCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_deleteCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_deleteCustomer.Location = new System.Drawing.Point(791, 215);
            this.btn_deleteCustomer.Name = "btn_deleteCustomer";
            this.btn_deleteCustomer.Size = new System.Drawing.Size(132, 29);
            this.btn_deleteCustomer.TabIndex = 10;
            this.btn_deleteCustomer.Text = "Xóa người dùng";
            this.btn_deleteCustomer.UseVisualStyleBackColor = false;
            this.btn_deleteCustomer.Click += new System.EventHandler(this.btn_deleteCustomer_Click);
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_phone.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_phone.Location = new System.Drawing.Point(113, 10);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(87, 20);
            this.lb_phone.TabIndex = 11;
            this.lb_phone.Text = "0848******";
            // 
            // lb_cubicMetreID
            // 
            this.lb_cubicMetreID.AutoSize = true;
            this.lb_cubicMetreID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_cubicMetreID.ForeColor = System.Drawing.Color.SteelBlue;
            this.lb_cubicMetreID.Location = new System.Drawing.Point(113, 43);
            this.lb_cubicMetreID.Name = "lb_cubicMetreID";
            this.lb_cubicMetreID.Size = new System.Drawing.Size(23, 20);
            this.lb_cubicMetreID.TabIndex = 12;
            this.lb_cubicMetreID.Text = "**";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_cubicMetreID);
            this.panel1.Controls.Add(this.lb_phone);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 130);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(791, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 100);
            this.panel2.TabIndex = 14;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel.Location = new System.Drawing.Point(606, 215);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(132, 29);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Hủy đồng hồ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(555, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 45);
            this.label3.TabIndex = 16;
            this.label3.Text = "TÙY CHỈNH";
            // 
            // RegisterCubicMetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1277, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_deleteCustomer);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_DeleteCubicMetre);
            this.Controls.Add(this.btn_CreateCubicMetre);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegisterCubicMetre";
            this.Text = "RegisterCubicMetre";
            this.Load += new System.EventHandler(this.RegisterCubicMetre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_CreateCubicMetre;
        private System.Windows.Forms.Button btn_DeleteCubicMetre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_deleteCustomer;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_cubicMetreID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
    }
}