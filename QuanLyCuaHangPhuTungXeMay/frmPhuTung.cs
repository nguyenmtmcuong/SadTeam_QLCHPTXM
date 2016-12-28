using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCuaHangPhuTungXeMay.Properties;

namespace QuanLyCuaHangPhuTungXeMay
{
    public partial class frmPhuTung : Form
    {
        PhuTungControl ptCtrl = new PhuTungControl();
        PhuTung pt = new PhuTung();
        int flag = 0;

        public frmPhuTung()
        {
            InitializeComponent();
        }

        private void frmPhuTung_Load(object sender, EventArgs e)
        {
            DataTable dtpt = new DataTable();
            dtpt = ptCtrl.GetData();
            dgvPhuTung.DataSource = dtpt;
            bingding();
            dis_en(false);
        }

        void bingding()
        {
            txtMaPT.DataBindings.Clear();
            txtMaPT.DataBindings.Add("Text", dgvPhuTung.DataSource, "MaPT");
            cbbLoaiXe.DataBindings.Clear();
            cbbLoaiXe.DataBindings.Add("Text", dgvPhuTung.DataSource, "MaLoaiXe");
            txtTenPT.DataBindings.Clear();
            txtTenPT.DataBindings.Add("Text", dgvPhuTung.DataSource, "TenPhuTung");
            txtDonVi.DataBindings.Clear();
            txtDonVi.DataBindings.Add("Text", dgvPhuTung.DataSource, "DonVi");
            txtGiaNhap.DataBindings.Clear();
            txtGiaNhap.DataBindings.Add("Text", dgvPhuTung.DataSource, "GiaNhap");
            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", dgvPhuTung.DataSource, "GiaBan");
            txtSoLuongTon.DataBindings.Clear();
            txtSoLuongTon.DataBindings.Add("Text", dgvPhuTung.DataSource, "SoLuongTon");
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", dgvPhuTung.DataSource, "GhiChu");
        }

        void dis_en(bool e)
        {
            txtMaPT.Enabled = e;
            cbbLoaiXe.Enabled = e;
            txtTenPT.Enabled = e;
            txtDonVi.Enabled = e;
            txtGiaNhap.Enabled = e;
            txtGiaBan.Enabled = e;
            txtSoLuongTon.Enabled = e;
            txtGhiChu.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnHuy.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        void GanDuLieu(PhuTung pt)
        {
            pt.MaPT = txtMaPT.Text.Trim();
            pt.TenPT = txtTenPT.Text.Trim();
            pt.MaLoai = cbbLoaiXe.SelectedValue.ToString();
            pt.DonVi = txtDonVi.Text.Trim();
            pt.GiaNhap = int.Parse(txtGiaNhap.Text.Trim());
            pt.GiaBan = int.Parse(txtGiaBan.Text.Trim());
            pt.SLTon = int.Parse(txtSoLuongTon.Text.Trim());
            pt.GhiChu = txtGhiChu.Text.Trim();
        }

        private void LoadcmbLoaiXe()
        {
            LoaiXeControl lxctr = new LoaiXeControl();
            cbbLoaiXe.DataSource = lxctr.GetData();
            cbbLoaiXe.DisplayMember = "TenThuongGoi";
            cbbLoaiXe.ValueMember = "MaLX";
            cbbLoaiXe.SelectedIndex = 0;
        }

        void XoaDuLieu()
        {
            txtMaPT.Text = "";
            cbbLoaiXe.Text = "";
            txtTenPT.Text = "";
            txtDonVi.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtSoLuongTon.Text = "";
            txtGhiChu.Text = "";
            LoadcmbLoaiXe();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            XoaDuLieu();
            dis_en(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_en(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ptCtrl.XoaPhuTung(txtMaPT.Text.Trim()))
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                return;
            frmPhuTung_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu(pt);
            if (flag == 0)
            {
                if (ptCtrl.ThemPhuTung(pt))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ptCtrl.SuaPhuTung(pt))
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmPhuTung_Load(sender, e);
            dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmPhuTung_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                frmPhuTung fnv = new frmPhuTung();
                this.Close();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dtpt = new DataTable();
            dtpt = ptCtrl.GetData();
            dgvPhuTung.DataSource = dtpt;
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            dgvPhuTung.DataSource = ptCtrl.GetDataTim(txtTim.Text);
        }


    }
}
