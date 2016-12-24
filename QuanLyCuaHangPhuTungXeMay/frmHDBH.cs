using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangPhuTungXeMay
{
    public partial class frmHDBH : Form
    {
        KhachHangModel khmod = new KhachHangModel();
        HDBHControl hdbhctr = new HDBHControl();
        HDBH hd = new HDBH();
        int flag=0;
        public frmHDBH()
        {
            InitializeComponent();
        }

        private void frmHDBH_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hdbhctr.GetData();
            dgvDanhSachHoaDon.DataSource=dt;
            //bingding();
        }

        //private void bingding()
        //{
        //    txtMaHD.DataBindings.Clear();
        //    txtMaHD.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"MaHD");
        //    cbbBienSo.DataBindings.Clear();
        //    cbbBienSo.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"BienSo");
        //    //cbbMaKH.DataBindings.Clear();
        //    //.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"MaKH");
        //    cbbMaNV.DataBindings.Clear();
        //    cbbMaNV.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"MaNV");
        //    txtNgay.DataBindings.Clear();
        //    txtNgay.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"NgayLap");
        //    txtKhuyenMai.DataBindings.Clear();
        //    txtKhuyenMai.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"KhuyenMai");
        //    txtThanhTien.DataBindings.Clear();
        //    txtThanhTien.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"ThanhTien");
        //    cbbMaPhuTung.DataBindings.Clear();
        //    cbbMaPhuTung.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"MaPT");
        //    cbbTenPhuTung.DataBindings.Clear();
        //    cbbTenPhuTung.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"TenPhuTung");
        //    txtSoLuong.DataBindings.Clear();
        //    txtSoLuong.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"SoLuong");
        //    txtDonGia.DataBindings.Clear();
        //    txtDonGia.DataBindings.Add("Text",dgvDanhSachHoaDon.DataSource,"DonGia");
        //}

        private void dis_en(bool e)
        {
            txtMaHD.Enabled = e;
            cbbMaNV.Enabled = e;
            //cbbMaKH.Enabled = e;
            cbbBienSo.Enabled = e;
            btnTao.Enabled = !e;
            btnXoa.Enabled = !e;
            btnIn.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnNgayLap.Enabled = e;
        }

        //private void LoadcbbMaKH()
        //{
        //    KhachHangControl khctr = new KhachHangControl();
        //    cbbMaKH.DataSource = khctr.GetData();
        //    cbbMaKH.DisplayMember = "MaKH";
        //    cbbMaKH.ValueMember = "MaKH";
        //}

        private void cleardata()
        {
            txtMaHD.Text = "";
            txtNgay.Text = "";
            txtKhuyenMai.Text = "";
            txtThanhTien.Text = "";
            txtNgay.Text = DateTime.Now.Date.ToShortDateString();
            //LoadcbbMaKH();
        }

        private void adddata(HDBH hd)
        {
            hd.MaHoaDon = txtMaHD.Text.Trim();
            //hd.MaKH = cbbMaKH.SelectedValue.ToString();
            hd.BienSo = cbbBienSo.SelectedValue.ToString();
            hd.NguoiLap = cbbMaNV.SelectedValue.ToString();
            //hd.KhuyenMai = txtKhuyenMai.Text.Trim();
            //hd.MaPT = cbbMaPhuTung.SelectedValue.ToString();
            hd.NgayLap = txtNgay.Text.Trim();
            //hd.KhuyenMai = txtKhuyenMai.Text.Trim();
            //hd.ThanhTien = Double.Parse(txtThanhTien.Text.Trim());
            //hd.MaPT = cbbMaPhuTung.SelectedValue.ToString();
            //hd.SoLuong = Int32.Parse(txtSoLuong.Text.Trim());
            //hd.DonGia = Int32.Parse(txtDonGia.Text.Trim());
        }

        
        private void btnTao_Click(object sender, EventArgs e)
        {
            dis_en(true);
            cleardata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            adddata(hd);
            if (flag == 0)
            {
                if (hdbhctr.AddData(hd))
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            frmHDBH_Load(sender, e);
            dis_en(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnBot_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachPhuTung_DataSourceChanged(object sender, EventArgs e)
        {
            //bingding();
        }

        private void cbbMaKH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //DataTable dtkh = khmod.GetData_fromIDKH(cbbMaKH.Text);
            //cbbBienSo.Text = dtkh.Rows[0]["BienSo"].ToString();
        }


    }
}
