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
    public partial class Frmchucvu : Form
    {
        private QuanLyNhanSuDbContext db = DBService.db;
        private int index = 0, index1 = 0;
        public Frmchucvu()
        {
            InitializeComponent();
        }
        private CHUCVU getnhanvienByForm()
        {
            CHUCVU ans = new CHUCVU();
            ans.TEN = txtten.Text;
            ans.GHICHU = txtghichu.Text;
            ans.KIHIEUCHUCVU = txtkihieu.Text ;
            ans.PHUCAPCHUCVU = 0;
           

            return ans;
        }
        private void Loadthongtin()
        {
            int i = 0;
            string keyword = txtTimKiem.Text;
            var dbNV = db.CHUCVUs.ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           Ten = p.TEN,
                           Ghichu = p.GHICHU,
                         kihieuchucvu=p.KIHIEUCHUCVU,
                         phucapchucvu=p.PHUCAPCHUCVU



                       }).ToList()

                       ;

            dgvthongtin.DataSource = dbNV.Where(p => p.Ten.Contains(keyword)).ToList();

            // cập nhật index 
            index = index1;
            try
            {
                dgvthongtin.Rows[index].Cells["STT"].Selected = true;
                dgvthongtin.Select();
            }
            catch { }
        }
        private void ClearControl()
        {
            try
            {
                txtten.Text = "";
                txtghichu.Text = "";
                txtkihieu.Text = "";
                txtphucap.Text = "";
          

            }
            catch { }
        }
        private void UpdateDetail()
        {
            ClearControl();
            try
            {
                CHUCVU tg = getnhanvienByID();

                if (tg == null || tg.ID == 0) return;

                // cập nhật trên giao diện
                txtten.Text = tg.TEN;
                txtphucap.Text = tg.PHUCAPCHUCVU.Value.ToString();
                txtkihieu.Text = tg.KIHIEUCHUCVU;
                txtghichu.Text = tg.GHICHU;
             


                index1 = index;
                index = dgvthongtin.SelectedRows[0].Index;
            }
            catch { }

        }
        private CHUCVU getnhanvienByID()
        {
            try
            {
                int id = (int)dgvthongtin.SelectedRows[0].Cells["ID"].Value;
                CHUCVU x = db.CHUCVUs.Where(p => p.ID == id).FirstOrDefault();
                return (x != null) ? x : new CHUCVU();
            }
            catch
            {
                return new CHUCVU();
            }
        }
        private bool Check()
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Tên không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int cnt = db.CHUCVUs.Where(p => p.TEN == txtten.Text).ToList().Count;
            if (cnt > 0)
            {
                bool ok = false;
                if (btnSua.Text == "Lưu")
                {
                    // Nếu là sửa
                    CHUCVU tg = getnhanvienByID();
                    if (tg.TEN == txtten.Text) ok = true;
                }

                if (!ok)
                {
                    MessageBox.Show("Tên đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (txtkihieu.Text == "")
            {
                MessageBox.Show("kí hiệu trống không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtphucap.Text == "")
            {
                MessageBox.Show("Phụ cấp không để trống không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;

        }
        private void Frmchucvu_Load(object sender, EventArgs e)
        {
            txtten.Enabled = false;
            txtghichu.Enabled = false;
            txtkihieu.Enabled = false;
            txtphucap.Enabled = false;
            Loadthongtin();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            Loadthongtin();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Check())
            {

                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Text = "Xóa";

                group.Enabled = false;
                txtten.Enabled = false;
                txtghichu.Enabled = false;
                txtkihieu.Enabled = false;
                txtphucap.Enabled = false;
                dgvthongtin.Enabled = true;

                btntimkiem.Enabled = true;
                txtTimKiem.Enabled = true;

                try
                {
                    CHUCVU tg = getnhanvienByForm();
                    db.CHUCVUs.Add(tg);
                    db.SaveChanges();



                    MessageBox.Show("Thêm  thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm  thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                Loadthongtin();
            }

            return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHUCVU tg = getnhanvienByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có thông tin  nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSua.Text == "Sửa")
            {

                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Text = "Hủy";

                groupthongtin.Enabled = true;
                txtten.Enabled = true;
                txtghichu.Enabled = true;
                txtkihieu.Enabled = true;
                txtphucap.Enabled = true;
                dgvthongtin.Enabled = false;

                btntimkiem.Enabled = false;
                txtTimKiem.Enabled = false;
                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Text = "Xóa";

                    groupthongtin.Enabled = false;
                    txtten.Enabled = false;
                    txtghichu.Enabled = false;
                    txtkihieu.Enabled = false;
                    txtphucap.Enabled = false;
                    dgvthongtin.Enabled = true;

                    btntimkiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    CHUCVU tgs = getnhanvienByForm();
                    tg.TEN = tgs.TEN;
                    tg.KIHIEUCHUCVU = tgs.KIHIEUCHUCVU;
                    tg.GHICHU = tgs.GHICHU;
                    tg.PHUCAPCHUCVU = tgs.PHUCAPCHUCVU;
                   

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sửa thông tin  thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin  thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Loadthongtin();
                }

                return;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (btnXoa.Text == "Xóa")
            {
                CHUCVU tg = getnhanvienByID();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có đầu  nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin đầu  này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                try
                {


                    db.CHUCVUs.Remove(tg);
                    db.SaveChanges();


                    MessageBox.Show("Xóa thông tin đầu  thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa thông tin đầu  thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Loadthongtin();
                return;
            }

            if (btnXoa.Text == "Hủy")
            {
                btnXoa.Text = "Xóa";
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";

                btnThem.Enabled = true;
                btnSua.Enabled = true;

                groupthongtin.Enabled = false;
                txtten.Enabled = false;
                txtghichu.Enabled = false;
                txtkihieu.Enabled = false;
                txtphucap.Enabled = false;
                dgvthongtin.Enabled = true;

                btntimkiem.Enabled = true;
                txtTimKiem.Enabled = true;

                UpdateDetail();

                return;
            }
        }

        private void dgvthongtin_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetail();
        }
    }
}
