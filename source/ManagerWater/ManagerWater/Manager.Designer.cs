
namespace ManagerWater
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngKýCấpNướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateCubicMetre = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_findPhone = new System.Windows.Forms.Button();
            this.btn_findName = new System.Windows.Forms.Button();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(535, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ";
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(41, 199);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.RowHeadersWidth = 51;
            this.CustomerGridView.RowTemplate.Height = 29;
            this.CustomerGridView.Size = new System.Drawing.Size(1187, 369);
            this.CustomerGridView.TabIndex = 1;
            this.CustomerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGridView_CellContentClick);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(820, 142);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(201, 27);
            this.inputName.TabIndex = 2;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // inputPhone
            // 
            this.inputPhone.Location = new System.Drawing.Point(343, 145);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Size = new System.Drawing.Size(201, 27);
            this.inputPhone.TabIndex = 3;
            this.inputPhone.TextChanged += new System.EventHandler(this.inputPhone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(688, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(145, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại khách hàng: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýCấpNướcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngKýCấpNướcToolStripMenuItem
            // 
            this.đăngKýCấpNướcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateCubicMetre});
            this.đăngKýCấpNướcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.đăngKýCấpNướcToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.đăngKýCấpNướcToolStripMenuItem.Name = "đăngKýCấpNướcToolStripMenuItem";
            this.đăngKýCấpNướcToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.đăngKýCấpNướcToolStripMenuItem.Text = "Menu";
            this.đăngKýCấpNướcToolStripMenuItem.Click += new System.EventHandler(this.đăngKýCấpNướcToolStripMenuItem_Click);
            // 
            // btnCreateCubicMetre
            // 
            this.btnCreateCubicMetre.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCreateCubicMetre.Name = "btnCreateCubicMetre";
            this.btnCreateCubicMetre.Size = new System.Drawing.Size(250, 26);
            this.btnCreateCubicMetre.Text = "Đăng ký đồng hồ nước";
            this.btnCreateCubicMetre.Click += new System.EventHandler(this.btnCreateCubicMetre_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(1175, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Đăng xuất";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_findPhone
            // 
            this.btn_findPhone.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_findPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_findPhone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_findPhone.Location = new System.Drawing.Point(550, 145);
            this.btn_findPhone.Name = "btn_findPhone";
            this.btn_findPhone.Size = new System.Drawing.Size(94, 29);
            this.btn_findPhone.TabIndex = 8;
            this.btn_findPhone.Text = "Tìm";
            this.btn_findPhone.UseVisualStyleBackColor = false;
            this.btn_findPhone.Click += new System.EventHandler(this.btn_findPhone_Click);
            // 
            // btn_findName
            // 
            this.btn_findName.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_findName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_findName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_findName.Location = new System.Drawing.Point(1027, 140);
            this.btn_findName.Name = "btn_findName";
            this.btn_findName.Size = new System.Drawing.Size(94, 29);
            this.btn_findName.TabIndex = 9;
            this.btn_findName.Text = "Tìm";
            this.btn_findName.UseVisualStyleBackColor = false;
            this.btn_findName.Click += new System.EventHandler(this.btn_findName_Click);
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Pay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Pay.Location = new System.Drawing.Point(1102, 43);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(149, 38);
            this.btn_Pay.TabIndex = 10;
            this.btn_Pay.Text = "Tính tiền nước";
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 11;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1263, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.btn_findName);
            this.Controls.Add(this.btn_findPhone);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPhone);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngKýCấpNướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCreateCubicMetre;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_findPhone;
        private System.Windows.Forms.Button btn_findName;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Panel panel1;
    }
}