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
    public partial class Frmthannhannhanvien : Form
    {
        private QuanLyNhanSuDbContext db = DBService.db;
        private int index = 0, index1 = 0;
        public Frmthannhannhanvien()
        {
            InitializeComponent();
        }
        private void LoadControl()
        {
            groupThongtin.Enabled = false;
            cbxgioitinh.SelectedIndex = 0;

            cbxtienganh.DataSource = db.NGOAINGUs.ToList();
            cbxtienganh.ValueMember = "ID";
            cbxtienganh.DisplayMember = "TEN";

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

        }
        private void LoadDgvNhanVien()
        {
            int i = 0;
            string keyword = txtTimKiem.Text;
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
                           Trinhdotienganh = p.NGOAINGUID == null ? "Không" : db.NGOAINGUs.Where(nn => nn.ID == p.NGOAINGUID).FirstOrDefault().TEN,
                           luong = p.LUONG,
                           trinhdohv = p.TRINHDOHOCVANID == null ? "Không" : db.TRINHDOHOCVANs.Where(td => td.ID == p.TRINHDOHOCVANID).FirstOrDefault().TEN
                       }).ToList()

                       ;

            dgvNhanvien.DataSource = dbNV.Where(p => p.quequan.Contains(keyword) || p.TENNV.Contains(keyword) || p.GIOTINH.Contains(keyword))
                                     .ToList();

            // cập nhật index 
            index = index1;
            try
            {
                dgvNhanvien.Rows[index].Cells["STT"].Selected = true;
                dgvNhanvien.Select();
            }
            catch { }
        }
        private void LoaddgvThannhan()
        {
            int i = 0;

            var dbNV = db.THANNHANs.ToList()
                       .Select(p => new
                       {

                           STTTN = ++i,
                           IDTN = p.IDTN,
                           MATN = p.MATN,
                           TENTN = p.HOTEN,
                           NS = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                           GT1 = p.GIOITINH == 0 ? "Nữ" : "Nam",
                           MOIQH = p.QUANHEGDID

                       }).ToList()

                       ;

            dgvThannhan.DataSource = dbNV;

            // cập nhật index 
            index = index1;
            try
            {
                dgvNhanvien.Rows[index].Cells["STTTN"].Selected = true;
                dgvNhanvien.Select();

            }
            catch { }
        }

       

        private void Loadthannhannhanvien()
        {
            int i = 0;
            int id = (int)dgvNhanvien.SelectedRows[0].Cells["ID"].Value;
            var dbNV = db.THANNHANs.Where(p => p.NHANVIENID == id).ToList()
                       .Select(p => new
                       {

                           STTTN = ++i,
                           IDTN = p.IDTN,
                           MATN = p.MATN,
                           TENTN = p.HOTEN,
                           NS = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy"),
                           GT1 = p.GIOITINH == 0 ? "Nữ" : "Nam",
                           MOIQH = p.QUANHEGDID

                       }).ToList()

                       ;

            dgvThannhan.DataSource = dbNV;

            // cập nhật index 
            index = index1;
            try
            {
                dgvNhanvien.Rows[index].Cells["STTTN"].Selected = true;
                dgvNhanvien.Select();

            }
            catch { }
        }
        private void Frmthannhannhanvien_Load(object sender, EventArgs e)
        {
            LoadControl();
            LoadDgvNhanVien();
            LoaddgvThannhan();
        }
        private void ClearControl()
        {
            try
            {
                textBox1.Text = "";
                txtmanv.Text = "";
                txttennhanvien.Text = "";
                txtquequan.Text = "";
                datengaysinh.Value = DateTime.Now;
                cbxchucvu.SelectedIndex = 0;
                cbxphongban.SelectedIndex = 0;
                cbxdantoc.SelectedIndex = 0;
                cbxtongiao.SelectedIndex = 0;
                cbxtrinhdo.SelectedIndex = 0;
                cbxtienganh.SelectedIndex = 0;
            }
            catch { }
        }
        private void UpdateDetail()
        {
            ClearControl();
            try
            {
                NHANVIEN tg = getnhanvienByID();

                if (tg == null || tg.ID == 0) return;

                // cập nhật trên giao diện
                txtmanv.Text = tg.MANV;
                textBox1.Text = tg.LUONG.ToString();
                txtquequan.Text = tg.NOISINH;
                txttennhanvien.Text = tg.HOTEN;
                cbxtienganh.SelectedValue = tg.NGOAINGUID;
                cbxchucvu.SelectedValue = tg.CHUCVUID;
                cbxphongban.SelectedValue = tg.PHONGBANID;
                cbxtongiao.SelectedValue = tg.TONGIAOID;
                cbxtrinhdo.SelectedValue = tg.TRINHDOHOCVANID;
                cbxdantoc.SelectedValue = tg.DANTOCID;
                cbxgioitinh.SelectedIndex = (int)tg.GIOITINH;
                datengaysinh.Value = (DateTime)tg.NGAYSINH;
                index1 = index;
                index = dgvNhanvien.SelectedRows[0].Index;
            }
            catch { }

        }
        private bool Check()
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Mã nhân viên trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int cnt = db.NHANVIENs.Where(p => p.MANV == txtmanv.Text).ToList().Count;
            if (cnt > 0)
            {
                bool ok = false;
                if (btnSua.Text == "Lưu")
                {
                    // Nếu là sửa
                    NHANVIEN tg = getnhanvienByID();
                    if (tg.MANV == txtmanv.Text) ok = true;
                }

                if (!ok)
                {
                    MessageBox.Show("Mã đã được sư dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (txttennhanvien.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtquequan.Text == "")
            {
                MessageBox.Show("Quê quán không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }
        private NHANVIEN getnhanvienByID()
        {
            try
            {
                int id = (int)dgvNhanvien.SelectedRows[0].Cells["ID"].Value;
                NHANVIEN nhanvien = db.NHANVIENs.Where(p => p.ID == id).FirstOrDefault();
                return (nhanvien != null) ? nhanvien : new NHANVIEN();
            }
            catch
            {
                return new NHANVIEN();
            }
        }

        private void dgvNhanvien_SelectionChanged(object sender, EventArgs e)
        {

            UpdateDetail();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {

                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";

                groupThongtin.Enabled = true;
                dgvNhanvien.Enabled = false;
                ClearControl();

                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {

                    btnThem.Text = "Thêm";
                    btnSua.Enabled = true;
                    btnXoa.Text = "Xóa";
                    groupThongtin.Enabled = false;
                    dgvNhanvien.Enabled = true;

                    try
                    {
                        NHANVIEN tg = getnhanvienByForm();
                        db.NHANVIENs.Add(tg);
                        db.SaveChanges();



                        MessageBox.Show("Thêm thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thông tin sách thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    LoadDgvNhanVien();
                }

                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NHANVIEN tg = getnhanvienByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có thông tin sách nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSua.Text == "Sửa")
            {

                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Text = "Hủy";

                groupThongtin.Enabled = true;
                dgvNhanvien.Enabled = false;

                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Text = "Xóa";

                    groupThongtin.Enabled = false;
                    dgvNhanvien.Enabled = true;

                    NHANVIEN tgs = getnhanvienByForm();
                    tg.MANV = tgs.MANV;
                    tg.HOTEN = tgs.HOTEN;
                    tg.NOISINH = tgs.NOISINH;
                    tg.GIOITINH = tgs.GIOITINH;
                    tg.NGAYSINH = tgs.NGAYSINH;
                    tg.TRINHDOHOCVANID = tgs.TRINHDOHOCVANID;
                    tg.CHUCVUID = tgs.CHUCVUID;
                    tg.PHONGBANID = tgs.PHONGBANID;
                    tg.TONGIAOID = tgs.TONGIAOID;
                    tg.DANTOCID = tgs.DANTOCID;
                    tg.NGOAINGUID = tgs.NGOAINGUID;

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sửa thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin sách thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadDgvNhanVien();
                }

                return;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                NHANVIEN tg = getnhanvienByID();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có đầu sách nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin đầu sách này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                try
                {


                    db.NHANVIENs.Remove(tg);
                    db.SaveChanges();


                    MessageBox.Show("Xóa thông tin đầu sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa thông tin đầu sách thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadDgvNhanVien();
                return;
            }

            if (btnXoa.Text == "Hủy")
            {
                btnXoa.Text = "Xóa";
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";

                btnThem.Enabled = true;
                btnSua.Enabled = true;

                groupThongtin.Enabled = false;
                dgvNhanvien.Enabled = true;

                UpdateDetail();

                return;
            }

        }

        private void Cbxxem_Click(object sender, EventArgs e)
        {
            Loadthannhannhanvien();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            UpdateDetail();
        }

        private NHANVIEN getnhanvienByForm()
        {
            NHANVIEN ans = new NHANVIEN();
            ans.MANV = txtmanv.Text;
            ans.HOTEN = txttennhanvien.Text;
            ans.NOISINH = txtquequan.Text;
            ans.NGOAINGUID = (int)cbxtienganh.SelectedValue;
            ans.GIOITINH = cbxgioitinh.SelectedIndex;
            ans.NGAYSINH = datengaysinh.Value;
            ans.CHUCVUID = (int)cbxchucvu.SelectedValue;
            ans.PHONGBANID = (int)cbxphongban.SelectedValue;
            ans.DANTOCID = (int)cbxdantoc.SelectedValue;
            ans.TONGIAOID = (int)cbxtongiao.SelectedValue;
            ans.TRINHDOHOCVANID = (int)cbxtrinhdo.SelectedValue;
            ans.LUONG = 0;

            return ans;
        }


    }
}
