using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmCTSanPham : Form
    {
        ISanPhamService _IsanPhamService;
        ILoaiSpService _IloaiSpService;
        INhaCungCapService _InhaCungCapService;
        IDanhMucService _IDanhMucService;
        IDonViService _IdonViService;
        ICTSanPhamService _IcTSanPhamService;
        Guid _idWhenclick;
        public FrmCTSanPham()
        {
            InitializeComponent(); 
            _IcTSanPhamService = new CTSanPhamService();
            _IDanhMucService = new DanhMucService();
            _IdonViService = new DonViService();
            _IloaiSpService = new LoaiSpService();
            _InhaCungCapService = new NhaCungCapService();
            _IsanPhamService = new SanPhamService();
            LoadAll();
            LoadData();
        }
        public void LoadAll()
        {
            cmbTenSP.Items.Add("Mời Chọn");
            cmbLoaiSp.Items.Add("Mời Chọn");
            cmbNhaCC.Items.Add("Mời Chọn");
            cmbDanhMuc.Items.Add("Mời Chọn");
            cmbDonVi.Items.Add("Mời Chọn");
            foreach (var x in _IsanPhamService.GetAll())
            {
                cmbTenSP.Items.Add(x.TenSp);
            }
            foreach (var x in _IloaiSpService.GetAll())
            {
                cmbLoaiSp.Items.Add(x.TenLoaiSp);
            }
            foreach (var x in _InhaCungCapService.GetAll())
            {
                cmbNhaCC.Items.Add(x.TenNhaCungCap);
            }
            foreach (var x in _IDanhMucService.GetAll())
            {
                cmbDanhMuc.Items.Add(x.TenDanhMuc);
            }
            foreach (var x in _IdonViService.GetAll())
            {
                cmbDonVi.Items.Add(x.TenDonVi);
            }
            cmbTenSP.SelectedIndex = 0;
            cmbNhaCC.SelectedIndex = 0;
            cmbLoaiSp.SelectedIndex = 0;
            cmbDonVi.SelectedIndex = 0;
            cmbDanhMuc.SelectedIndex = 0;
        }
        public void LoadData()
        {
            dgridCTSanPham.ColumnCount = 9;
            dgridCTSanPham.Columns[0].Name = "ID";
            dgridCTSanPham.Columns[0].Visible = false;
            dgridCTSanPham.Columns[1].Name = "Tên Sản Phẩm";
            dgridCTSanPham.Columns[2].Name = "Loại Sản Phẩm";
            dgridCTSanPham.Columns[3].Name = "Nhà Cung Cấp";
            dgridCTSanPham.Columns[4].Name = "Danh Mục";
            dgridCTSanPham.Columns[5].Name = "Đơn Vị";
            dgridCTSanPham.Columns[6].Name = "Giá Nhập";
            dgridCTSanPham.Columns[7].Name = "Giá Bán";
            dgridCTSanPham.Columns[8].Name = "Số Lượng";
            dgridCTSanPham.Rows.Clear();
            foreach (var x in _IcTSanPhamService.GetAll())
            {
                dgridCTSanPham.Rows.Add(x.ChiTietSanPhams.IdChiTietSP, x.SanPhams.TenSp, x.LoaiSps.TenLoaiSp, x.NhaCungCaps.TenNhaCungCap, x.DanhMucs.TenDanhMuc, x.DonVis.TenDonVi, x.ChiTietSanPhams.GiaNhap, x.ChiTietSanPhams.GiaBan, x.ChiTietSanPhams.SoLuong);
            }
        }
        public ChiTietSanPham GetDataFromGui()
        {
            return new ChiTietSanPham()
            {
                IdSp = _IsanPhamService.GetAll().FirstOrDefault(c => c.TenSp == cmbTenSP.Text).IdSp,
                IdLoaiSp = _IloaiSpService.GetAll().FirstOrDefault(c => c.TenLoaiSp == cmbLoaiSp.Text).IdLoaiSp,
                IdNhaCungCap = _InhaCungCapService.GetAll().FirstOrDefault(c => c.TenNhaCungCap == cmbNhaCC.Text).IdNhaCungCap,
                IdDanhMuc = _IDanhMucService.GetAll().FirstOrDefault(c => c.TenDanhMuc == cmbDanhMuc.Text).IdDanhMuc,
                IdDonVi = _IdonViService.GetAll().FirstOrDefault(c => c.TenDonVi == cmbDonVi.Text).IdDonVi,
                HinhAnh = convertImage(pictureBox1.Image),
                GiaBan = decimal.Parse(txtGiaBan.Text),
                GiaNhap = decimal.Parse(txtGiaNhap.Text),
                SoLuong = int.Parse(txtSoLuong.Text)
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbTenSP.SelectedIndex == 0 ||
            cmbNhaCC.SelectedIndex == 0 ||
            cmbLoaiSp.SelectedIndex == 0 ||
            cmbDonVi.SelectedIndex == 0 ||
            cmbDanhMuc.SelectedIndex == 0 ||
            txtGiaBan.Text == "" ||
            txtGiaNhap.Text == "" ||
            txtSoLuong.Text == "" ||
            pictureBox1.Image == null)
            {
                MessageBox.Show("Bạn chưa chọn đủ thông tin");
            }
            else
            {
                CTSanPhamView ctSanPham = new CTSanPhamView();
                ctSanPham.ChiTietSanPhams = GetDataFromGui();
                MessageBox.Show(_IcTSanPhamService.Add(ctSanPham));
                LoadData();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog LoadImage = new OpenFileDialog();
            if (LoadImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(LoadImage.FileName);
            }
            lblChonAnh.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            lblChonAnh.Visible = true;
            cmbTenSP.SelectedIndex = 0;
            cmbNhaCC.SelectedIndex = 0;
            cmbLoaiSp.SelectedIndex = 0;
            cmbDonVi.SelectedIndex = 0;
            cmbDanhMuc.SelectedIndex = 0;

        }
        public byte[] convertImage(Image image)
        {
            MemoryStream m = new MemoryStream();
            image.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        public Image convertByte(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        private void dgridCTSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || _IcTSanPhamService.GetAll().Count==index) return;
            _idWhenclick = Guid.Parse(dgridCTSanPham.Rows[index].Cells[0].Value.ToString());
            var ctSanPham = _IcTSanPhamService.GetAll().FirstOrDefault(c => c.ChiTietSanPhams.IdChiTietSP == _idWhenclick);
            pictureBox1.Image = convertByte(ctSanPham.ChiTietSanPhams.HinhAnh);
            txtGiaBan.Text = ctSanPham.ChiTietSanPhams.GiaBan.ToString();
            txtGiaNhap.Text = ctSanPham.ChiTietSanPhams.GiaNhap.ToString();
            txtSoLuong.Text = ctSanPham.ChiTietSanPhams.SoLuong.ToString();
            cmbDanhMuc.SelectedIndex= cmbDanhMuc.FindStringExact(_IDanhMucService.GetAll().FirstOrDefault(c=>c.IdDanhMuc==ctSanPham.ChiTietSanPhams.IdDanhMuc).TenDanhMuc);
            cmbDonVi.SelectedIndex= cmbDonVi.FindStringExact(_IdonViService.GetAll().FirstOrDefault(c=>c.IdDonVi==ctSanPham.ChiTietSanPhams.IdDonVi).TenDonVi);
            cmbLoaiSp.SelectedIndex= cmbLoaiSp.FindStringExact(_IloaiSpService.GetAll().FirstOrDefault(c=>c.IdLoaiSp==ctSanPham.ChiTietSanPhams.IdLoaiSp).TenLoaiSp);
            cmbNhaCC.SelectedIndex= cmbNhaCC.FindStringExact(_InhaCungCapService.GetAll().FirstOrDefault(c=>c.IdNhaCungCap==ctSanPham.ChiTietSanPhams.IdNhaCungCap).TenNhaCungCap);
            cmbTenSP.SelectedIndex= cmbTenSP.FindStringExact(_IsanPhamService.GetAll().FirstOrDefault(c=>c.IdSp==ctSanPham.ChiTietSanPhams.IdSp).TenSp);
            lblChonAnh.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CTSanPhamView ctSanPham = new CTSanPhamView();
            ctSanPham.ChiTietSanPhams = GetDataFromGui();
            ctSanPham.ChiTietSanPhams.IdChiTietSP = _idWhenclick;
            MessageBox.Show(_IcTSanPhamService.Update(ctSanPham));
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CTSanPhamView ctSanPham = new CTSanPhamView();
            ctSanPham.ChiTietSanPhams = GetDataFromGui();
            ctSanPham.ChiTietSanPhams.IdChiTietSP = _idWhenclick;
            MessageBox.Show(_IcTSanPhamService.Delete(ctSanPham));
            LoadData();
        }
    }
}
