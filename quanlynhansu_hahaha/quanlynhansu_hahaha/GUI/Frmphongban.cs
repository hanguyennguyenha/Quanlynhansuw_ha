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
    public partial class Frmphongban : Form
    {

        private QuanLyNhanSuDbContext db = DBService.db;
        private int index = 0, index1 = 0;
        public Frmphongban()
        {
            InitializeComponent();
        }
        private PHONGBAN getnhanvienByForm()
        {
            PHONGBAN ans = new PHONGBAN();
            ans.TEN = txtten.Text;
            ans.IDCAPTREN = 0;
            ans.KIHIEUPHONG = txtkihieuphong.Text;
            ans.MOTAPHONGBAN = txtmota.Text;
            ans.DIADIEM = txtdiadiem.Text;


            return ans;
        }
        private void Loadthongtin()
        {
            int i = 0;
            string keyword = txtTimKiem.Text;
            var dbNV = db.PHONGBANs.ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           Ten = p.TEN,
                           DIACHI = p.DIADIEM,
                           MOTAPHONGBAN = p.MOTAPHONGBAN,
                           Kihieuphong=p.KIHIEUPHONG,
                           IDCAPTREN=p.IDCAPTREN

            

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
                txtid.Text = "";
                txtmota.Text = "";
                txtdiadiem.Text = "";
                txtkihieuphong.Text = "";
             
            }
            catch { }
        }
        private void UpdateDetail()
        {
            ClearControl();
            try
            {
                PHONGBAN tg = getnhanvienByID();

                if (tg == null || tg.ID == 0) return;

                // cập nhật trên giao diện
                txtten.Text = tg.TEN;
                txtid.Text = tg.IDCAPTREN.ToString();
                txtdiadiem.Text = tg.DIADIEM;
                txtmota.Text = tg.MOTAPHONGBAN;
                txtkihieuphong.Text = tg.KIHIEUPHONG;


                index1 = index;
                index = dgvthongtin.SelectedRows[0].Index;
            }
            catch { }

        }
        private PHONGBAN getnhanvienByID()
        {
            try
            {
                int id = (int)dgvthongtin.SelectedRows[0].Cells["ID"].Value;
                PHONGBAN x = db.PHONGBANs.Where(p => p.ID == id).FirstOrDefault();
                return (x != null) ? x : new PHONGBAN();
            }
            catch
            {
                return new PHONGBAN();
            }
        }
        private bool Check()
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Tên không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int cnt = db.PHONGBANs.Where(p => p.TEN == txtten.Text).ToList().Count;
            if (cnt > 0)
            {
                bool ok = false;
                if (btnSua.Text == "Lưu")
                {
                    // Nếu là sửa
                    PHONGBAN tg = getnhanvienByID();
                    if (tg.TEN == txtten.Text) ok = true;
                }

                if (!ok)
                {
                    MessageBox.Show("Tên đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (txtid.Text == "")
            {
                MessageBox.Show("id trống không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtdiadiem.Text == "")
            {
                MessageBox.Show("Địa điểm trống không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Check())
            {

                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Text = "Xóa";

                group.Enabled = false;
                txtdiadiem.Enabled = false;
                txtten.Enabled = false;
                txtid.Enabled = false;
                txtkihieuphong.Enabled = false;
                txtmota.Enabled = false;
                dgvthongtin.Enabled = true;

                btntimkiem.Enabled = true;
                txtTimKiem.Enabled = true;

                try
                {
                    PHONGBAN tg = getnhanvienByForm();
                    db.PHONGBANs.Add(tg);
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
    

       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                PHONGBAN tg = getnhanvienByID();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có đầu  nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin đầu  này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                try
                {


                    db.PHONGBANs.Remove(tg);
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
                txtdiadiem.Enabled = false;
                txtten.Enabled = false;
                txtid.Enabled = false;
                txtkihieuphong.Enabled = false;
                txtmota.Enabled = false;
                dgvthongtin.Enabled = true;

                btntimkiem.Enabled = true;
                txtTimKiem.Enabled = true;

                UpdateDetail();

                return;
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            Loadthongtin();
        }

        private void Frmphongban_Load(object sender, EventArgs e)
        {
            txtdiadiem.Enabled = false;
            txtten.Enabled = false;
            txtid.Enabled = false;
            txtkihieuphong.Enabled = false;
            txtmota.Enabled = false;
            Loadthongtin();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            PHONGBAN tg = getnhanvienByID();
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
                txtdiadiem.Enabled = true;
                txtten.Enabled = true;
                txtid.Enabled = true;
                txtkihieuphong.Enabled = true;
                txtmota.Enabled = true;
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
                    txtdiadiem.Enabled = false;
                    txtten.Enabled = false;
                    txtid.Enabled = false;
                    txtkihieuphong.Enabled = false;
                    txtmota.Enabled = false;
                    dgvthongtin.Enabled = true;

                    btntimkiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    PHONGBAN tgs = getnhanvienByForm();
                    tg.TEN = tgs.TEN;
                    tg.IDCAPTREN = tgs.IDCAPTREN;
                    tg.MOTAPHONGBAN = tgs.MOTAPHONGBAN;
                    tg.KIHIEUPHONG = tgs.KIHIEUPHONG;
                    tg.DIADIEM = tgs.DIADIEM;

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

        private void dgvthongtin_SelectionChanged(object sender, EventArgs e)
        {
            UpdateDetail();
        }
    }
}
