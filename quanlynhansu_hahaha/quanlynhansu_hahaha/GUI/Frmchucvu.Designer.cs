namespace quanlynhansu_hahaha.GUI
{
    partial class Frmchucvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmchucvu));
            this.label2 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkihieu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.group = new System.Windows.Forms.GroupBox();
            this.dgvthongtin = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupthongtin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtphucap = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucapchucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kihieuchucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupthongtin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 89;
            this.label2.Text = "Ghi chú";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtghichu
            // 
            this.txtghichu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghichu.Location = new System.Drawing.Point(164, 214);
            this.txtghichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(249, 31);
            this.txtghichu.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 87;
            this.label1.Text = "Kí hiệu CV";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtkihieu
            // 
            this.txtkihieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkihieu.Location = new System.Drawing.Point(163, 175);
            this.txtkihieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtkihieu.Name = "txtkihieu";
            this.txtkihieu.Size = new System.Drawing.Size(249, 31);
            this.txtkihieu.TabIndex = 86;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.group);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 579);
            this.panel2.TabIndex = 22;
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.White;
            this.group.Controls.Add(this.dgvthongtin);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(1127, 577);
            this.group.TabIndex = 111;
            this.group.TabStop = false;
            this.group.Text = "Danh sách chức vụ";
            // 
            // dgvthongtin
            // 
            this.dgvthongtin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthongtin.BackgroundColor = System.Drawing.Color.White;
            this.dgvthongtin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvthongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.STT,
            this.Ten,
            this.phucapchucvu,
            this.kihieuchucvu,
            this.Ghichu});
            this.dgvthongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvthongtin.Location = new System.Drawing.Point(3, 22);
            this.dgvthongtin.Name = "dgvthongtin";
            this.dgvthongtin.RowTemplate.Height = 28;
            this.dgvthongtin.Size = new System.Drawing.Size(1121, 552);
            this.dgvthongtin.TabIndex = 1;
            this.dgvthongtin.SelectionChanged += new System.EventHandler(this.dgvthongtin_SelectionChanged);
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.groupthongtin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1129, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 579);
            this.panel3.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.btnSua);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 297);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(430, 150);
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
            // groupthongtin
            // 
            this.groupthongtin.Controls.Add(this.label3);
            this.groupthongtin.Controls.Add(this.label2);
            this.groupthongtin.Controls.Add(this.txtghichu);
            this.groupthongtin.Controls.Add(this.label1);
            this.groupthongtin.Controls.Add(this.txtkihieu);
            this.groupthongtin.Controls.Add(this.txtten);
            this.groupthongtin.Controls.Add(this.label4);
            this.groupthongtin.Controls.Add(this.label9);
            this.groupthongtin.Controls.Add(this.txtphucap);
            this.groupthongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupthongtin.Location = new System.Drawing.Point(0, 0);
            this.groupthongtin.Name = "groupthongtin";
            this.groupthongtin.Size = new System.Drawing.Size(430, 297);
            this.groupthongtin.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(163, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 41);
            this.label3.TabIndex = 90;
            this.label3.Text = "Thông tin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(164, 87);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(249, 31);
            this.txtten.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 84;
            this.label4.Text = "Tên chức vụ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(19, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 29);
            this.label9.TabIndex = 80;
            this.label9.Text = "Phụ cấp CV";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtphucap
            // 
            this.txtphucap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphucap.Location = new System.Drawing.Point(164, 129);
            this.txtphucap.Margin = new System.Windows.Forms.Padding(4);
            this.txtphucap.Name = "txtphucap";
            this.txtphucap.Size = new System.Drawing.Size(249, 31);
            this.txtphucap.TabIndex = 79;
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
            this.panel1.Size = new System.Drawing.Size(1561, 68);
            this.panel1.TabIndex = 21;
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
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(176, 12);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(467, 31);
            this.txtTimKiem.TabIndex = 113;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 30F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên chức vụ";
            this.Ten.Name = "Ten";
            // 
            // phucapchucvu
            // 
            this.phucapchucvu.DataPropertyName = "phucapchucvu";
            this.phucapchucvu.HeaderText = "Phụ cấp chức vụ";
            this.phucapchucvu.Name = "phucapchucvu";
            // 
            // kihieuchucvu
            // 
            this.kihieuchucvu.DataPropertyName = "kihieuchucvu";
            this.kihieuchucvu.HeaderText = "Kí hiệu chức vụ";
            this.kihieuchucvu.Name = "kihieuchucvu";
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            // 
            // Frmchucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Frmchucvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức vụ nhân viên";
            this.Load += new System.EventHandler(this.Frmchucvu_Load);
            this.panel2.ResumeLayout(false);
            this.group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongtin)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupthongtin.ResumeLayout(false);
            this.groupthongtin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkihieu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.DataGridView dgvthongtin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Panel groupthongtin;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtphucap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucapchucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kihieuchucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}