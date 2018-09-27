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
    public partial class FrmMain : Form
    {
        QuanLyNhanSuDbContext db = DAO.DBService.db;
        NHANVIEN nhanvien = new NHANVIEN();
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(NHANVIEN nv)
        {
            InitializeComponent();
            nhanvien = nv;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string chucvu = "";
            try
            {
                chucvu = db.CHUCVUs.Where(p => p.ID == nhanvien.CHUCVUID).FirstOrDefault().TEN;

            }
            catch { }

            if (chucvu == "Giám đốc" || chucvu == "Tổng Giám Đốc") return;

            ribbonPageGroup3.Visible = false;
            return;
            if (chucvu == "Trưởng phòng") return;

          
        }

        private void bardantoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmdantoc dt = new Frmdantoc();
            this.Hide();
            dt.ShowDialog();
            this.Show();
        }

        private void barnhanvientn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmthannhannhanvien dt = new Frmthannhannhanvien();
            this.Hide();
            dt.ShowDialog();
            this.Show();
        }

        private void bartongiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmtongiao dt = new Frmtongiao();
            this.Hide();
            dt.ShowDialog();
            this.Show();
        }

        private void barchucvu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmchucvu dt = new Frmchucvu();
            this.Hide();
            dt.ShowDialog();
            this.Show();
        }

        private void barphongban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmphongban dt = new Frmphongban();
            this.Hide();
            dt.ShowDialog();
            this.Show();
        }

        private void bartrinhdotienganh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmngoaingu dt = new Frmngoaingu();
            this.Hide();
            dt.ShowDialog();
            this.Show();
        }

        private void bartrinhdohocvan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frmtrinhdohocvan dt = new Frmtrinhdohocvan();
            this.Hide();
            dt.ShowDialog();
            this.Show();
        }

        private void bartaikhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTaikhoancanhan dt = new FrmTaikhoancanhan(nhanvien);
            this.Hide();
            dt.ShowDialog();
            this.Show();
        }

        private void bardangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barthongke_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongke dt = new FrmThongke();
            this.Hide();
            dt.ShowDialog();
            this.Show();
        }
    }
}
