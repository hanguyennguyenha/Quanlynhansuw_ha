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
    public partial class FrmTaikhoancanhan : Form
    {
        private QuanLyNhanSuDbContext db = DAO.DBService.db;
        private NHANVIEN nhanvien = new NHANVIEN();
        public FrmTaikhoancanhan()
        {
            InitializeComponent();
            DAO.DBService.Reload();
        }
        public FrmTaikhoancanhan(NHANVIEN nv)
        {
            InitializeComponent();

            nhanvien = nv;
        }

        private void FrmTaikhoancanhan_Load(object sender, EventArgs e)
        {

            txttennhanvien.Text = nhanvien.HOTEN;
            txtmanv.Text = nhanvien.MANV;
            txtgioitinh.Text = nhanvien.GIOITINH == 0 ? "Nữ" : "Nam";
            txtngaysinh.Text = ((DateTime)nhanvien.NGAYSINH).ToString("dd/MM/yyyy");
            txtquequan.Text = nhanvien.NOISINH;


            txtphongban.Text = "";
            try
            {
                txtphongban.Text = db.PHONGBANs.Where(p => p.ID == nhanvien.PHONGBANID).FirstOrDefault().TEN;
            }
            catch { }
            txtchucvu.Text = "";
            try
            {
                txtchucvu.Text = db.CHUCVUs.Where(p => p.ID == nhanvien.CHUCVUID).FirstOrDefault().TEN;

            }
            catch { }
            txtdantoc.Text = "";
            try
            {
                txtdantoc.Text = db.DANTOCs.Where(p => p.ID == nhanvien.DANTOCID).FirstOrDefault().TEN;

            }
            catch { }
            txttongiao.Text = "";
            try
            {
                txttongiao.Text = db.TONGIAOs.Where(p => p.ID == nhanvien.TONGIAOID).FirstOrDefault().TEN;

            }
            catch { }
            txttrinhdo.Text = "";
            try
            {
                txttrinhdo.Text = db.TRINHDOHOCVANs.Where(p => p.ID == nhanvien.TRINHDOHOCVANID).FirstOrDefault().TEN;

            }
            catch { }


        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Frmdoimatkhau tg = new Frmdoimatkhau(nhanvien);
            this.Hide();
            tg.ShowDialog();
            this.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
