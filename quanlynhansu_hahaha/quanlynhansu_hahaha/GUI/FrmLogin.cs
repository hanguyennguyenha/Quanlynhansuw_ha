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
    public partial class FrmLogin : Form
    {
        private QuanLyNhanSuDbContext db = DAO.DBService.db;
        public FrmLogin()
        {
            InitializeComponent();
            DAO.DBService.Reload();
        }

      
       // kiem tra dieu kien dang nhap tai khoan
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = txttaikhoandn.Text;
            string matkhau = txtmatkhau.Text;

            if (user == "")
            {
                MessageBox.Show("Tên tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cnt = db.NHANVIENs.Where(p => p.TAIKHOAN == user).ToList().Count;
            if (cnt == 0)
            {
                MessageBox.Show("Tên tài khoản không đúng " + user, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NHANVIEN nv = db.NHANVIENs.Where(p => p.TAIKHOAN == user).FirstOrDefault();
            if (nv.MATKHAU != matkhau)
            {
                MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            FrmMain main = new FrmMain(nv);
            this.Hide();
            main.ShowDialog();
            this.Show();

            txttaikhoandn.Text = "";
            txtmatkhau.Text = "";
        }
    
       
        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
