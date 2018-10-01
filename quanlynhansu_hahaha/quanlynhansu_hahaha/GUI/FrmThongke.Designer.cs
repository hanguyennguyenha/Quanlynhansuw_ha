namespace quanlynhansu_hahaha.GUI
{
    partial class FrmThongke
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongke));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupdantoc = new System.Windows.Forms.GroupBox();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOTINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUEQUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DANTOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONGBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhdohv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.combodotuoi = new System.Windows.Forms.ComboBox();
            this.cbxgioitinh = new System.Windows.Forms.ComboBox();
            this.cbxtrinhdo = new System.Windows.Forms.ComboBox();
            this.btnThongke = new DevExpress.XtraEditors.SimpleButton();
            this.cbxtongiao = new System.Windows.Forms.ComboBox();
            this.cbxdantoc = new System.Windows.Forms.ComboBox();
            this.cbxphongban = new System.Windows.Forms.ComboBox();
            this.cbxchucvu = new System.Windows.Forms.ComboBox();
            this.radiotongiao = new System.Windows.Forms.RadioButton();
            this.radiothongkedantoc = new System.Windows.Forms.RadioButton();
            this.radiogioitinh = new System.Windows.Forms.RadioButton();
            this.radiotrinhdovanhoa = new System.Windows.Forms.RadioButton();
            this.RadioThongkeChucvu = new System.Windows.Forms.RadioButton();
            this.radiothongkedotuoi = new System.Windows.Forms.RadioButton();
            this.RadioThongKePhongBan = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupdantoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1758, 676);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.groupdantoc);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(598, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1158, 625);
            this.panel4.TabIndex = 2;
            // 
            // groupdantoc
            // 
            this.groupdantoc.BackColor = System.Drawing.Color.White;
            this.groupdantoc.Controls.Add(this.dgvNhanvien);
            this.groupdantoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupdantoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupdantoc.ForeColor = System.Drawing.Color.Black;
            this.groupdantoc.Location = new System.Drawing.Point(0, 0);
            this.groupdantoc.Name = "groupdantoc";
            this.groupdantoc.Size = new System.Drawing.Size(1156, 623);
            this.groupdantoc.TabIndex = 106;
            this.groupdantoc.TabStop = false;
            this.groupdantoc.Text = "Danh sách nhân viên";
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanvien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.STT,
            this.MANV,
            this.TENNV,
            this.GIOTINH,
            this.QUEQUAN,
            this.NGAYSINH,
            this.CHUCVU,
            this.DANTOC,
            this.PHONGBAN,
            this.Tongiao,
            this.trinhdohv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanvien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanvien.EnableHeadersVisualStyles = false;
            this.dgvNhanvien.GridColor = System.Drawing.Color.Black;
            this.dgvNhanvien.Location = new System.Drawing.Point(3, 22);
            this.dgvNhanvien.MultiSelect = false;
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.ReadOnly = true;
            this.dgvNhanvien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanvien.RowTemplate.Height = 28;
            this.dgvNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanvien.Size = new System.Drawing.Size(1150, 598);
            this.dgvNhanvien.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 55.83756F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.FillWeight = 104.4162F;
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.FillWeight = 104.4162F;
            this.TENNV.HeaderText = "Tên nhân viên";
            this.TENNV.Name = "TENNV";
            this.TENNV.ReadOnly = true;
            // 
            // GIOTINH
            // 
            this.GIOTINH.DataPropertyName = "GIOTINH";
            this.GIOTINH.FillWeight = 104.4162F;
            this.GIOTINH.HeaderText = "Giới tính";
            this.GIOTINH.Name = "GIOTINH";
            this.GIOTINH.ReadOnly = true;
            // 
            // QUEQUAN
            // 
            this.QUEQUAN.DataPropertyName = "QUEQUAN";
            this.QUEQUAN.FillWeight = 104.4162F;
            this.QUEQUAN.HeaderText = "Quê quán";
            this.QUEQUAN.Name = "QUEQUAN";
            this.QUEQUAN.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.FillWeight = 104.4162F;
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // CHUCVU
            // 
            this.CHUCVU.DataPropertyName = "CHUCVU";
            this.CHUCVU.FillWeight = 104.4162F;
            this.CHUCVU.HeaderText = "Chức vụ";
            this.CHUCVU.Name = "CHUCVU";
            this.CHUCVU.ReadOnly = true;
            // 
            // DANTOC
            // 
            this.DANTOC.DataPropertyName = "DANTOC";
            this.DANTOC.FillWeight = 104.4162F;
            this.DANTOC.HeaderText = "Dân tộc";
            this.DANTOC.Name = "DANTOC";
            this.DANTOC.ReadOnly = true;
            // 
            // PHONGBAN
            // 
            this.PHONGBAN.DataPropertyName = "PHONGBAN";
            this.PHONGBAN.FillWeight = 104.4162F;
            this.PHONGBAN.HeaderText = "Phòng ban";
            this.PHONGBAN.Name = "PHONGBAN";
            this.PHONGBAN.ReadOnly = true;
            // 
            // Tongiao
            // 
            this.Tongiao.DataPropertyName = "Tongiao";
            this.Tongiao.FillWeight = 104.4162F;
            this.Tongiao.HeaderText = "Tôn giáo";
            this.Tongiao.Name = "Tongiao";
            this.Tongiao.ReadOnly = true;
            // 
            // trinhdohv
            // 
            this.trinhdohv.DataPropertyName = "trinhdohv";
            this.trinhdohv.FillWeight = 104.4162F;
            this.trinhdohv.HeaderText = "Trình độ học vấn";
            this.trinhdohv.Name = "trinhdohv";
            this.trinhdohv.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.combodotuoi);
            this.panel3.Controls.Add(this.cbxgioitinh);
            this.panel3.Controls.Add(this.cbxtrinhdo);
            this.panel3.Controls.Add(this.btnThongke);
            this.panel3.Controls.Add(this.cbxtongiao);
            this.panel3.Controls.Add(this.cbxdantoc);
            this.panel3.Controls.Add(this.cbxphongban);
            this.panel3.Controls.Add(this.cbxchucvu);
            this.panel3.Controls.Add(this.radiotongiao);
            this.panel3.Controls.Add(this.radiothongkedantoc);
            this.panel3.Controls.Add(this.radiogioitinh);
            this.panel3.Controls.Add(this.radiotrinhdovanhoa);
            this.panel3.Controls.Add(this.RadioThongkeChucvu);
            this.panel3.Controls.Add(this.radiothongkedotuoi);
            this.panel3.Controls.Add(this.RadioThongKePhongBan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 625);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 146;
            this.label2.Text = "Các mục thống kê";
            // 
            // combodotuoi
            // 
            this.combodotuoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combodotuoi.FormattingEnabled = true;
            this.combodotuoi.Items.AddRange(new object[] {
            "Dưới 20 tuổi",
            "Từ 20 đến dưới 30 tuổi",
            "Từ 30 đến dưới 40tuổi",
            "Từ 40 đến dưới 50 tuổi",
            "Từ 50 tuổi trở lên"});
            this.combodotuoi.Location = new System.Drawing.Point(277, 191);
            this.combodotuoi.Margin = new System.Windows.Forms.Padding(4);
            this.combodotuoi.Name = "combodotuoi";
            this.combodotuoi.Size = new System.Drawing.Size(302, 31);
            this.combodotuoi.TabIndex = 145;
            // 
            // cbxgioitinh
            // 
            this.cbxgioitinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxgioitinh.FormattingEnabled = true;
            this.cbxgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxgioitinh.Location = new System.Drawing.Point(277, 246);
            this.cbxgioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbxgioitinh.Name = "cbxgioitinh";
            this.cbxgioitinh.Size = new System.Drawing.Size(302, 31);
            this.cbxgioitinh.TabIndex = 144;
            // 
            // cbxtrinhdo
            // 
            this.cbxtrinhdo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtrinhdo.FormattingEnabled = true;
            this.cbxtrinhdo.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxtrinhdo.Location = new System.Drawing.Point(277, 302);
            this.cbxtrinhdo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxtrinhdo.Name = "cbxtrinhdo";
            this.cbxtrinhdo.Size = new System.Drawing.Size(302, 31);
            this.cbxtrinhdo.TabIndex = 143;
            // 
            // btnThongke
            // 
            this.btnThongke.Appearance.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.Appearance.Options.UseFont = true;
            this.btnThongke.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(181, 468);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(194, 57);
            this.btnThongke.TabIndex = 133;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // cbxtongiao
            // 
            this.cbxtongiao.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtongiao.FormattingEnabled = true;
            this.cbxtongiao.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxtongiao.Location = new System.Drawing.Point(277, 402);
            this.cbxtongiao.Margin = new System.Windows.Forms.Padding(4);
            this.cbxtongiao.Name = "cbxtongiao";
            this.cbxtongiao.Size = new System.Drawing.Size(302, 31);
            this.cbxtongiao.TabIndex = 142;
            // 
            // cbxdantoc
            // 
            this.cbxdantoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxdantoc.FormattingEnabled = true;
            this.cbxdantoc.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxdantoc.Location = new System.Drawing.Point(277, 347);
            this.cbxdantoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbxdantoc.Name = "cbxdantoc";
            this.cbxdantoc.Size = new System.Drawing.Size(302, 31);
            this.cbxdantoc.TabIndex = 141;
            // 
            // cbxphongban
            // 
            this.cbxphongban.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxphongban.FormattingEnabled = true;
            this.cbxphongban.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxphongban.Location = new System.Drawing.Point(277, 140);
            this.cbxphongban.Margin = new System.Windows.Forms.Padding(4);
            this.cbxphongban.Name = "cbxphongban";
            this.cbxphongban.Size = new System.Drawing.Size(302, 31);
            this.cbxphongban.TabIndex = 140;
            // 
            // cbxchucvu
            // 
            this.cbxchucvu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxchucvu.FormattingEnabled = true;
            this.cbxchucvu.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxchucvu.Location = new System.Drawing.Point(277, 100);
            this.cbxchucvu.Margin = new System.Windows.Forms.Padding(4);
            this.cbxchucvu.Name = "cbxchucvu";
            this.cbxchucvu.Size = new System.Drawing.Size(302, 31);
            this.cbxchucvu.TabIndex = 139;
            // 
            // radiotongiao
            // 
            this.radiotongiao.AutoSize = true;
            this.radiotongiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiotongiao.Location = new System.Drawing.Point(28, 405);
            this.radiotongiao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radiotongiao.Name = "radiotongiao";
            this.radiotongiao.Size = new System.Drawing.Size(197, 24);
            this.radiotongiao.TabIndex = 138;
            this.radiotongiao.Text = "Thống kê theo tôn giáo";
            this.radiotongiao.UseVisualStyleBackColor = true;
            this.radiotongiao.CheckedChanged += new System.EventHandler(this.radiotongiao_CheckedChanged);
            // 
            // radiothongkedantoc
            // 
            this.radiothongkedantoc.AutoSize = true;
            this.radiothongkedantoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiothongkedantoc.Location = new System.Drawing.Point(28, 354);
            this.radiothongkedantoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radiothongkedantoc.Name = "radiothongkedantoc";
            this.radiothongkedantoc.Size = new System.Drawing.Size(193, 24);
            this.radiothongkedantoc.TabIndex = 137;
            this.radiothongkedantoc.Text = "Thống kê theo dân tộc";
            this.radiothongkedantoc.UseVisualStyleBackColor = true;
            this.radiothongkedantoc.CheckedChanged += new System.EventHandler(this.radiothongkedantoc_CheckedChanged);
            // 
            // radiogioitinh
            // 
            this.radiogioitinh.AutoSize = true;
            this.radiogioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiogioitinh.Location = new System.Drawing.Point(28, 249);
            this.radiogioitinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radiogioitinh.Name = "radiogioitinh";
            this.radiogioitinh.Size = new System.Drawing.Size(194, 24);
            this.radiogioitinh.TabIndex = 136;
            this.radiogioitinh.Text = "Thống kê theo giới tính";
            this.radiogioitinh.UseVisualStyleBackColor = true;
            this.radiogioitinh.CheckedChanged += new System.EventHandler(this.radiogioitinh_CheckedChanged);
            // 
            // radiotrinhdovanhoa
            // 
            this.radiotrinhdovanhoa.AutoSize = true;
            this.radiotrinhdovanhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiotrinhdovanhoa.Location = new System.Drawing.Point(28, 305);
            this.radiotrinhdovanhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radiotrinhdovanhoa.Name = "radiotrinhdovanhoa";
            this.radiotrinhdovanhoa.Size = new System.Drawing.Size(217, 24);
            this.radiotrinhdovanhoa.TabIndex = 135;
            this.radiotrinhdovanhoa.Text = "Thống kê trình độ văn hóa";
            this.radiotrinhdovanhoa.UseVisualStyleBackColor = true;
            this.radiotrinhdovanhoa.CheckedChanged += new System.EventHandler(this.radiotrinhdovanhoa_CheckedChanged);
            // 
            // RadioThongkeChucvu
            // 
            this.RadioThongkeChucvu.AutoSize = true;
            this.RadioThongkeChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioThongkeChucvu.Location = new System.Drawing.Point(28, 101);
            this.RadioThongkeChucvu.Name = "RadioThongkeChucvu";
            this.RadioThongkeChucvu.Size = new System.Drawing.Size(158, 24);
            this.RadioThongkeChucvu.TabIndex = 132;
            this.RadioThongkeChucvu.Text = "Thống kê chức vụ";
            this.RadioThongkeChucvu.UseVisualStyleBackColor = true;
            this.RadioThongkeChucvu.CheckedChanged += new System.EventHandler(this.RadioThongkeChucvu_CheckedChanged);
            // 
            // radiothongkedotuoi
            // 
            this.radiothongkedotuoi.AutoSize = true;
            this.radiothongkedotuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiothongkedotuoi.Location = new System.Drawing.Point(28, 198);
            this.radiothongkedotuoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radiothongkedotuoi.Name = "radiothongkedotuoi";
            this.radiothongkedotuoi.Size = new System.Drawing.Size(188, 24);
            this.radiothongkedotuoi.TabIndex = 134;
            this.radiothongkedotuoi.Text = "Thống kê theo độ tuổi";
            this.radiothongkedotuoi.UseVisualStyleBackColor = true;
            this.radiothongkedotuoi.CheckedChanged += new System.EventHandler(this.radiothongkedotuoi_CheckedChanged);
            // 
            // RadioThongKePhongBan
            // 
            this.RadioThongKePhongBan.AutoSize = true;
            this.RadioThongKePhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioThongKePhongBan.Location = new System.Drawing.Point(28, 146);
            this.RadioThongKePhongBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadioThongKePhongBan.Name = "RadioThongKePhongBan";
            this.RadioThongKePhongBan.Size = new System.Drawing.Size(216, 24);
            this.RadioThongKePhongBan.TabIndex = 131;
            this.RadioThongKePhongBan.Text = "Thống kê theo phòng ban";
            this.RadioThongKePhongBan.UseVisualStyleBackColor = true;
            this.RadioThongKePhongBan.CheckedChanged += new System.EventHandler(this.RadioThongKePhongBan_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1756, 49);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê danh sách nhân viên theo các mục";
            // 
            // FrmThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1758, 676);
            this.Controls.Add(this.panel1);
            this.Name = "FrmThongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmThongke_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupdantoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox combodotuoi;
        private System.Windows.Forms.ComboBox cbxgioitinh;
        private System.Windows.Forms.ComboBox cbxtrinhdo;
        private DevExpress.XtraEditors.SimpleButton btnThongke;
        private System.Windows.Forms.ComboBox cbxtongiao;
        private System.Windows.Forms.ComboBox cbxdantoc;
        private System.Windows.Forms.ComboBox cbxphongban;
        private System.Windows.Forms.ComboBox cbxchucvu;
        private System.Windows.Forms.RadioButton radiotongiao;
        private System.Windows.Forms.RadioButton radiothongkedantoc;
        private System.Windows.Forms.RadioButton radiogioitinh;
        private System.Windows.Forms.RadioButton radiotrinhdovanhoa;
        private System.Windows.Forms.RadioButton RadioThongkeChucvu;
        private System.Windows.Forms.RadioButton radiothongkedotuoi;
        private System.Windows.Forms.RadioButton RadioThongKePhongBan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupdantoc;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOTINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUEQUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DANTOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONGBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdohv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}