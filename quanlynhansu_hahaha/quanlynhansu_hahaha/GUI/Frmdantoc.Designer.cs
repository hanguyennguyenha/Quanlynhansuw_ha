namespace quanlynhansu_hahaha.GUI
{
    partial class Frmdantoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdantoc));
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvthongtin = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupthongtin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.group = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).BeginInit();
            this.groupthongtin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.group.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // dgvthongtin
            // 
            this.dgvthongtin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthongtin.BackgroundColor = System.Drawing.Color.White;
            this.dgvthongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.STT,
            this.Ten,
            this.Ghichu});
            this.dgvthongtin.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvthongtin.Location = new System.Drawing.Point(3, 22);
            this.dgvthongtin.Name = "dgvthongtin";
            this.dgvthongtin.RowTemplate.Height = 28;
            this.dgvthongtin.Size = new System.Drawing.Size(682, 499);
            this.dgvthongtin.TabIndex = 1;
            this.dgvthongtin.SelectionChanged += new System.EventHandler(this.dgvthongtin12_SelectionChanged);
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên dân tộc";
            this.Ten.Name = "Ten";
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(164, 75);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(249, 31);
            this.txtten.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 84;
            this.label4.Text = "Tên dân tộc";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(19, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 29);
            this.label9.TabIndex = 80;
            this.label9.Text = "Ghi chú";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupthongtin
            // 
            this.groupthongtin.Controls.Add(this.label3);
            this.groupthongtin.Controls.Add(this.txtten);
            this.groupthongtin.Controls.Add(this.label4);
            this.groupthongtin.Controls.Add(this.label9);
            this.groupthongtin.Controls.Add(this.txtghichu);
            this.groupthongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupthongtin.Location = new System.Drawing.Point(0, 0);
            this.groupthongtin.Name = "groupthongtin";
            this.groupthongtin.Size = new System.Drawing.Size(430, 172);
            this.groupthongtin.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(164, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 41);
            this.label3.TabIndex = 91;
            this.label3.Text = "Thông tin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtghichu
            // 
            this.txtghichu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghichu.Location = new System.Drawing.Point(164, 117);
            this.txtghichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(249, 31);
            this.txtghichu.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.groupthongtin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(692, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 526);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.btnSua);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 142);
            this.panel5.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(17, 72);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(407, 57);
            this.btnXoa.TabIndex = 85;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(227, 7);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(196, 57);
            this.btnSua.TabIndex = 84;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(18, 7);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(188, 57);
            this.btnThem.TabIndex = 83;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.White;
            this.group.Controls.Add(this.dgvthongtin);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(1122, 524);
            this.group.TabIndex = 111;
            this.group.TabStop = false;
            this.group.Text = "Danh sách dân tộc";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.group);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 526);
            this.panel2.TabIndex = 4;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(707, 12);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(112, 33);
            this.btntimkiem.TabIndex = 115;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 114;
            this.label11.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(176, 12);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(467, 31);
            this.txtTimKiem.TabIndex = 113;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 68);
            this.panel1.TabIndex = 3;
            // 
            // Frmdantoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frmdantoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dân tộc";
            this.Load += new System.EventHandler(this.Frmdantoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).EndInit();
            this.groupthongtin.ResumeLayout(false);
            this.groupthongtin.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.group.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView dgvthongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel groupthongtin;
        private System.Windows.Forms.TextBox txtghichu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}