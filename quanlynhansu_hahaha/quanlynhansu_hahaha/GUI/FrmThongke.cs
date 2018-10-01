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
    public partial class FrmThongke : Form
    {
        private QuanLyNhanSuDbContext db = DBService.db;
       
        public FrmThongke()
        {
            InitializeComponent();
        }

        private void FrmThongke_Load(object sender, EventArgs e)
        {
            LoadControl();
            LoadDgvNhanVien();
        }
        private void DisableControl()
        {
            cbxchucvu.Enabled = false;
            cbxdantoc.Enabled = false;
            cbxgioitinh.Enabled = false;
            cbxphongban.Enabled = false;
            cbxtongiao.Enabled = false;
            cbxtrinhdo.Enabled = false;
            combodotuoi.Enabled = false;
        }
        private void LoadControl()
        {

            cbxchucvu.DataSource = db.CHUCVUs.ToList();
            cbxgioitinh.SelectedIndex = 0;

            cbxdantoc.DataSource = db.DANTOCs.ToList();
            cbxdantoc.ValueMember = "ID";
            cbxdantoc.DisplayMember = "TEN";

            cbxtongiao.DataSource = db.TONGIAOs.ToList();
            cbxtongiao.ValueMember = "ID";
            cbxtongiao.DisplayMember = "TEN";

            cbxtrinhdo.DataSource = db.TRINHDOHOCVANs.ToList();
            cbxtrinhdo.ValueMember = "ID";
            cbxtrinhdo.DisplayMember = "TEN";

            cbxchucvu.DataSource = db.CHUCVUs.ToList();
            cbxchucvu.ValueMember = "ID";
            cbxchucvu.DisplayMember = "TEN";

            cbxphongban.DataSource = db.PHONGBANs.ToList();
            cbxphongban.ValueMember = "ID";
            cbxphongban.DisplayMember = "TEN";
            combodotuoi.SelectedIndex = 0;
            DisableControl();

        }
        private void LoadDgvNhanVien()
        {
            int i = 0;

            var dbNV = db.NHANVIENs.ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           MANV = p.MANV,
                           quequan = p.NOISINH,
                           TENNV = p.HOTEN,
                           PHONGBAN = p.PHONGBANID == null ? "Không" : db.PHONGBANs.Where(pb => pb.ID == p.PHONGBANID).FirstOrDefault().TEN,
                           NGAYSINH = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                           GIOTINH = p.GIOITINH == 0 ? "Nữ" : "Nam",
                           DANTOC = p.DANTOCID == null ? "Không" : db.DANTOCs.Where(dt => dt.ID == p.DANTOCID).FirstOrDefault().TEN,
                           Tongiao = p.TONGIAOID == null ? "Không" : db.TONGIAOs.Where(tg => tg.ID == p.TONGIAOID).FirstOrDefault().TEN,
                           CHUCVU = p.CHUCVUID == null ? "Không" : db.CHUCVUs.Where(cv => cv.ID == p.CHUCVUID).FirstOrDefault().TEN,

                           trinhdohv = p.TRINHDOHOCVANID == null ? "Không" : db.TRINHDOHOCVANs.Where(td => td.ID == p.TRINHDOHOCVANID).FirstOrDefault().TEN
                       }).ToList()

                       ;

            dgvNhanvien.DataSource = dbNV;

            // cập nhật index 

        }
        private void ThongKePhongBan()
        {
            int idPB = (int)cbxphongban.SelectedValue;
            int i = 0;

            var dbNV = db.NHANVIENs.Where(p => p.PHONGBANID == idPB).ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           MANV = p.MANV,
                           quequan = p.NOISINH,
                           TENNV = p.HOTEN,
                           PHONGBAN = p.PHONGBANID == null ? "Không" : db.PHONGBANs.Where(pb => pb.ID == p.PHONGBANID).FirstOrDefault().TEN,
                           NGAYSINH = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                           GIOTINH = p.GIOITINH == 0 ? "Nữ" : "Nam",
                           DANTOC = p.DANTOCID == null ? "Không" : db.DANTOCs.Where(dt => dt.ID == p.DANTOCID).FirstOrDefault().TEN,
                           Tongiao = p.TONGIAOID == null ? "Không" : db.TONGIAOs.Where(tg => tg.ID == p.TONGIAOID).FirstOrDefault().TEN,
                           CHUCVU = p.CHUCVUID == null ? "Không" : db.CHUCVUs.Where(cv => cv.ID == p.CHUCVUID).FirstOrDefault().TEN,

                           trinhdohv = p.TRINHDOHOCVANID == null ? "Không" : db.TRINHDOHOCVANs.Where(td => td.ID == p.TRINHDOHOCVANID).FirstOrDefault().TEN
                       }).ToList()

                       ;

            dgvNhanvien.DataSource = dbNV;

            // cập nhật index 

        }
        private void ThongKeChucvu()
        {
            int id = (int)cbxchucvu.SelectedValue;
            int i = 0;

            var dbNV = db.NHANVIENs.Where(p => p.CHUCVUID == id).ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           MANV = p.MANV,
                           quequan = p.NOISINH,
                           TENNV = p.HOTEN,
                           PHONGBAN = p.PHONGBANID == null ? "Không" : db.PHONGBANs.Where(pb => pb.ID == p.PHONGBANID).FirstOrDefault().TEN,
                           NGAYSINH = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                           GIOTINH = p.GIOITINH == 0 ? "Nữ" : "Nam",
                           DANTOC = p.DANTOCID == null ? "Không" : db.DANTOCs.Where(dt => dt.ID == p.DANTOCID).FirstOrDefault().TEN,
                           Tongiao = p.TONGIAOID == null ? "Không" : db.TONGIAOs.Where(tg => tg.ID == p.TONGIAOID).FirstOrDefault().TEN,
                           CHUCVU = p.CHUCVUID == null ? "Không" : db.CHUCVUs.Where(cv => cv.ID == p.CHUCVUID).FirstOrDefault().TEN,

                           trinhdohv = p.TRINHDOHOCVANID == null ? "Không" : db.TRINHDOHOCVANs.Where(td => td.ID == p.TRINHDOHOCVANID).FirstOrDefault().TEN
                       }).ToList()

                       ;

            dgvNhanvien.DataSource = dbNV;

            // cập nhật index 

        }
        private void Thongkegioitinh()
        {
            var id = cbxgioitinh.SelectedIndex;
            int i = 0;

            var dbNV = db.NHANVIENs.Where(p => p.GIOITINH == id).ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           MANV = p.MANV,
                           quequan = p.NOISINH,
                           TENNV = p.HOTEN,
                           PHONGBAN = p.PHONGBANID == null ? "Không" : db.PHONGBANs.Where(pb => pb.ID == p.PHONGBANID).FirstOrDefault().TEN,
                           NGAYSINH = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                           GIOTINH = p.GIOITINH == 0 ? "Nữ" : "Nam",
                           DANTOC = p.DANTOCID == null ? "Không" : db.DANTOCs.Where(dt => dt.ID == p.DANTOCID).FirstOrDefault().TEN,
                           Tongiao = p.TONGIAOID == null ? "Không" : db.TONGIAOs.Where(tg => tg.ID == p.TONGIAOID).FirstOrDefault().TEN,
                           CHUCVU = p.CHUCVUID == null ? "Không" : db.CHUCVUs.Where(cv => cv.ID == p.CHUCVUID).FirstOrDefault().TEN,

                           trinhdohv = p.TRINHDOHOCVANID == null ? "Không" : db.TRINHDOHOCVANs.Where(td => td.ID == p.TRINHDOHOCVANID).FirstOrDefault().TEN
                       }).ToList()

                       ;

            dgvNhanvien.DataSource = dbNV;

            // cập nhật index 

        }
        private void Thongketongiao()
        {
            int id = (int)cbxtongiao.SelectedValue;
            int i = 0;

            var dbNV = db.NHANVIENs.Where(p => p.TONGIAOID == id).ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           MANV = p.MANV,
                           quequan = p.NOISINH,
                           TENNV = p.HOTEN,
                           PHONGBAN = p.PHONGBANID == null ? "Không" : db.PHONGBANs.Where(pb => pb.ID == p.PHONGBANID).FirstOrDefault().TEN,
                           NGAYSINH = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                           GIOTINH = p.GIOITINH == 0 ? "Nữ" : "Nam",
                           DANTOC = p.DANTOCID == null ? "Không" : db.DANTOCs.Where(dt => dt.ID == p.DANTOCID).FirstOrDefault().TEN,
                           Tongiao = p.TONGIAOID == null ? "Không" : db.TONGIAOs.Where(tg => tg.ID == p.TONGIAOID).FirstOrDefault().TEN,
                           CHUCVU = p.CHUCVUID == null ? "Không" : db.CHUCVUs.Where(cv => cv.ID == p.CHUCVUID).FirstOrDefault().TEN,

                           trinhdohv = p.TRINHDOHOCVANID == null ? "Không" : db.TRINHDOHOCVANs.Where(td => td.ID == p.TRINHDOHOCVANID).FirstOrDefault().TEN
                       }).ToList()

                       ;

            dgvNhanvien.DataSource = dbNV;

            // cập nhật index 

        }
        private void thongkehocvan()
        {
            int id = (int)cbxtrinhdo.SelectedValue;
            int i = 0;

            var dbNV = db.NHANVIENs.Where(p => p.TRINHDOHOCVANID == id).ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           MANV = p.MANV,
                           quequan = p.NOISINH,
                           TENNV = p.HOTEN,
                           PHONGBAN = p.PHONGBANID == null ? "Không" : db.PHONGBANs.Where(pb => pb.ID == p.PHONGBANID).FirstOrDefault().TEN,
                           NGAYSINH = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                           GIOTINH = p.GIOITINH == 0 ? "Nữ" : "Nam",
                           DANTOC = p.DANTOCID == null ? "Không" : db.DANTOCs.Where(dt => dt.ID == p.DANTOCID).FirstOrDefault().TEN,
                           Tongiao = p.TONGIAOID == null ? "Không" : db.TONGIAOs.Where(tg => tg.ID == p.TONGIAOID).FirstOrDefault().TEN,
                           CHUCVU = p.CHUCVUID == null ? "Không" : db.CHUCVUs.Where(cv => cv.ID == p.CHUCVUID).FirstOrDefault().TEN,

                           trinhdohv = p.TRINHDOHOCVANID == null ? "Không" : db.TRINHDOHOCVANs.Where(td => td.ID == p.TRINHDOHOCVANID).FirstOrDefault().TEN
                       }).ToList()

                       ;

            dgvNhanvien.DataSource = dbNV;

            // cập nhật index 

        }
        private void thongkedantoc()
        {
            int id = (int)cbxdantoc.SelectedValue;
            int i = 0;

            var dbNV = db.NHANVIENs.Where(p => p.DANTOCID == id).ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           MANV = p.MANV,
                           quequan = p.NOISINH,
                           TENNV = p.HOTEN,
                           PHONGBAN = p.PHONGBANID == null ? "Không" : db.PHONGBANs.Where(pb => pb.ID == p.PHONGBANID).FirstOrDefault().TEN,
                           NGAYSINH = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                           GIOTINH = p.GIOITINH == 0 ? "Nữ" : "Nam",
                           DANTOC = p.DANTOCID == null ? "Không" : db.DANTOCs.Where(dt => dt.ID == p.DANTOCID).FirstOrDefault().TEN,
                           Tongiao = p.TONGIAOID == null ? "Không" : db.TONGIAOs.Where(tg => tg.ID == p.TONGIAOID).FirstOrDefault().TEN,
                           CHUCVU = p.CHUCVUID == null ? "Không" : db.CHUCVUs.Where(cv => cv.ID == p.CHUCVUID).FirstOrDefault().TEN,

                           trinhdohv = p.TRINHDOHOCVANID == null ? "Không" : db.TRINHDOHOCVANs.Where(td => td.ID == p.TRINHDOHOCVANID).FirstOrDefault().TEN
                       }).ToList()

                       ;

            dgvNhanvien.DataSource = dbNV;

            // cập nhật index 

        }

        private void RadioThongkeChucvu_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();
            if (RadioThongkeChucvu.Checked) cbxchucvu.Enabled = true;
        }

        private void RadioThongKePhongBan_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();

            if (RadioThongKePhongBan.Checked)

                cbxphongban.Enabled = true;
        }

        private void radiothongkedotuoi_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();
            combodotuoi.Enabled = true;
            thongkedotuoi();
        }

        private void radiogioitinh_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();
            if (radiogioitinh.Checked) cbxgioitinh.Enabled = true;
        }

        private void radiotrinhdovanhoa_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();
            if (radiotrinhdovanhoa.Checked)
                cbxtrinhdo.Enabled = true;
        }

        private void radiothongkedantoc_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();
            if (radiothongkedantoc.Checked)
                cbxdantoc.Enabled = true;
        }

        private void radiotongiao_CheckedChanged(object sender, EventArgs e)
        {
            DisableControl();
            if (radiotongiao.Checked)
                cbxtongiao.Enabled = true;
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (radiogioitinh.Checked)
            {
                cbxgioitinh.Enabled = true;
                Thongkegioitinh();
                return;
            }
            if (RadioThongkeChucvu.Checked)
            {
                cbxchucvu.Enabled = true;
                ThongKeChucvu();
                return;
            }
            if (radiothongkedantoc.Checked)
            {
                cbxdantoc.Enabled = true;
                thongkedantoc();
                return;
            }
            if (radiothongkedotuoi.Checked)
            {
                combodotuoi.Enabled = true;
                thongkedotuoi();
                return;

            }
            if (RadioThongKePhongBan.Checked)
            {
                cbxphongban.Enabled = true;
                ThongKePhongBan();
                return;
            }
            if (radiotrinhdovanhoa.Checked)
            {
                cbxtrinhdo.Enabled = true;
                thongkehocvan();
                return;
            }
            if (radiotongiao.Checked)
            {
                cbxtongiao.Enabled = true;
                Thongketongiao();
                return;
            }
            MessageBox.Show("Chưa có kiểu thống kê nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void thongkedotuoi()
        {
            int dotuoi = combodotuoi.SelectedIndex;
            int min = 0, max = 0;
            if (dotuoi == 0)
            {
                min = 0;
                max = 19;
            }
            if (dotuoi == 1)
            {
                min = 20;
                max = 29;
            }
            if (dotuoi == 2)
            {
                min = 30;
                max = 39;
            }
            if (dotuoi == 3)
            {
                min = 40;
                max = 49;
            }
            if (dotuoi == 4)
            {
                min = 50;
                max = 200;
            }
            int i = 0;

            var dbNV = db.NHANVIENs.Where(p => ((DateTime)p.NGAYSINH).Year >= (DateTime.Now.Year - max)).Where(p => ((DateTime)p.NGAYSINH).Year <= (DateTime.Now.Year - min)).ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           MANV = p.MANV,
                           quequan = p.NOISINH,
                           TENNV = p.HOTEN,
                           PHONGBAN = p.PHONGBANID == null ? "Không" : db.PHONGBANs.Where(pb => pb.ID == p.PHONGBANID).FirstOrDefault().TEN,
                           NGAYSINH = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                           GIOTINH = p.GIOITINH == 0 ? "Nữ" : "Nam",
                           DANTOC = p.DANTOCID == null ? "Không" : db.DANTOCs.Where(dt => dt.ID == p.DANTOCID).FirstOrDefault().TEN,
                           Tongiao = p.TONGIAOID == null ? "Không" : db.TONGIAOs.Where(tg => tg.ID == p.TONGIAOID).FirstOrDefault().TEN,
                           CHUCVU = p.CHUCVUID == null ? "Không" : db.CHUCVUs.Where(cv => cv.ID == p.CHUCVUID).FirstOrDefault().TEN,

                           trinhdohv = p.TRINHDOHOCVANID == null ? "Không" : db.TRINHDOHOCVANs.Where(td => td.ID == p.TRINHDOHOCVANID).FirstOrDefault().TEN
                       }).ToList()

                       ;

            dgvNhanvien.DataSource = dbNV;
        }


    }
}
