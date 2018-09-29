namespace quanlynhansu_hahaha.GUI
{
    partial class Frmdoimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdoimatkhau));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoimatkhau = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxacnhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatkhaucu = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnDoimatkhau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtxacnhan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmatkhaumoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtmatkhaucu);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 476);
            this.panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(489, 345);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(200, 57);
            this.btnHuy.TabIndex = 92;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoimatkhau.Appearance.Options.UseFont = true;
            this.btnDoimatkhau.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnDoimatkhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoimatkhau.Image")));
            this.btnDoimatkhau.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDoimatkhau.Location = new System.Drawing.Point(150, 345);
            this.btnDoimatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.Size = new System.Drawing.Size(207, 57);
            this.btnDoimatkhau.TabIndex = 91;
            this.btnDoimatkhau.Text = "Đổi mật khẩu";
            this.btnDoimatkhau.Click += new System.EventHandler(this.btnDoimatkhau_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(149, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 31);
            this.label3.TabIndex = 90;
            this.label3.Text = "Xác nhận";
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxacnhan.Location = new System.Drawing.Point(316, 263);
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.Size = new System.Drawing.Size(373, 31);
            this.txtxacnhan.TabIndex = 89;
            this.txtxacnhan.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(150, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 88;
            this.label1.Text = "Mật khẩu mới";
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhaumoi.Location = new System.Drawing.Point(316, 205);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.Size = new System.Drawing.Size(373, 31);
            this.txtmatkhaumoi.TabIndex = 87;
            this.txtmatkhaumoi.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(149, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 31);
            this.label2.TabIndex = 86;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // txtmatkhaucu
            // 
            this.txtmatkhaucu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhaucu.Location = new System.Drawing.Point(316, 142);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.Size = new System.Drawing.Size(373, 31);
            this.txtmatkhaucu.TabIndex = 85;
            this.txtmatkhaucu.UseSystemPasswordChar = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(292, 75);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(235, 29);
            this.label.TabIndex = 84;
            this.label.Text = "Thông tin tài khoản";
            // 
            // Frmdoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 476);
            this.Controls.Add(this.panel1);
            this.Name = "Frmdoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnDoimatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxacnhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatkhaucu;
        private System.Windows.Forms.Label label;
    }
}