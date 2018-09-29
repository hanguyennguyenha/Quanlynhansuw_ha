using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlynhansu_hahaha.DAO;
namespace quanlynhansu_hahaha.GUI
{
    public partial class Frmdoimatkhau : Form
    {
        private QuanLyNhanSuDbContext db = DAO.DBService.db;
        private NHANVIEN nhanvien = new NHANVIEN();
        public Frmdoimatkhau()
        {
            InitializeComponent();
            DAO.DBService.Reload();
        }
        public Frmdoimatkhau(NHANVIEN nv)
        {
            InitializeComponent();
            DAO.DBService.Reload();
            nhanvien = nv;
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            if (txtmatkhaucu.Text != nhanvien.MATKHAU)
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtmatkhaumoi.Text != txtxacnhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nhanvien.MATKHAU = txtmatkhaumoi.Text;
            db.SaveChanges();

            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
