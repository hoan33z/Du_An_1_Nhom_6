using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _3.PL.Views
{
    public partial class FrmDatHang : Form
    {
        ICTSanPhamService _cTSanPhamService;
        ICTHoaDonService _cTHoaDonService;
        IHoaDonService _hoaDonService;
        IKhachHangService _khachHangService;
        Guid _idgh;
        Guid _idsp;
        Guid _idkh;
        public FrmDatHang(Guid idkh)
        {
            InitializeComponent();
            _cTSanPhamService = new CTSanPhamService();
            _cTHoaDonService = new CTHoaDonService();
            _hoaDonService = new HoaDonService();
            _khachHangService = new KhachHangService();
            _idkh = idkh;
            LoadDSSanPham();
            loadKH();
            LoadGioHang();
            LoadLoc();
        }
        public void LoadDSSanPham()
        {
            dgridDSSanPham.ColumnCount = 9;
            dgridDSSanPham.Columns[0].Name = "ID";
            dgridDSSanPham.Columns[0].Visible = false;
            dgridDSSanPham.Columns[1].Name = "Tên Sản Phẩm";
            dgridDSSanPham.Columns[2].Name = "Loại Sản Phẩm";
            dgridDSSanPham.Columns[3].Name = "Giá Bán";
            dgridDSSanPham.Columns[4].Name = "Số Lượng";
            dgridDSSanPham.Columns[5].Name = "Giá Nhập";
            dgridDSSanPham.Columns[6].Name = "Nhà Cung Cấp";
            dgridDSSanPham.Columns[7].Name = "Danh Mục";
            dgridDSSanPham.Columns[8].Name = "Đơn Vị";
            dgridDSSanPham.Rows.Clear();
            foreach (var x in _cTSanPhamService.GetAll())
            {
                dgridDSSanPham.Rows.Add(
                    x.IdChiTietSP,
                    x.TenSp,
                    x.TenLoaiSp,
                    x.GiaBan,
                    x.SoLuong,
                    x.GiaNhap,
                    x.TenNhaCungCap,
                    x.TenDanhMuc,
                    x.TenDonVi
                    );
            }
        }
        public void loadKH()
        {
            var kh = _khachHangService.GetEdit(_idkh);
            txtTenKH.Text = kh.TenKh;
            txtSDT.Text = kh.SDT;
            txtGioiTinh.Text = kh.GioiTinh == 0 ? "Nam" : "Nữ";
            txtDCNhan.Text = kh.DCNhanHang;
            dateNgayNhan.Value = kh.NgayNhan;
        }
        public void LoadGioHang()
        {
            dgridGioHang.ColumnCount = 5;
            dgridGioHang.Columns[0].Name = "IDCTHD";
            dgridGioHang.Columns[0].Visible = false;
            dgridGioHang.Columns[1].Name = "Tên Sản Phẩm";
            dgridGioHang.Columns[2].Name = "Giá Bán";
            dgridGioHang.Columns[3].Name = "Số Lượng";
            dgridGioHang.Columns[4].Name = "Thành Tiền";
            dgridGioHang.Rows.Clear();
            Guid idhd = _hoaDonService.GetEdit(_idkh).IdHoaDon;
            List<CTHoaDonView> lsteditcthd = (from a in _cTHoaDonService.GetAll() where a.IdHoaDon == idhd select a).ToList();
            foreach (var x in lsteditcthd)
            {
                dgridGioHang.Rows.Add(x.IdCTHoaDon, x.TenSp, x.DonGia, x.SoLuongMua, x.DonGia * x.SoLuongMua);
            }
        }
        private void dgridDSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || _cTSanPhamService.GetAll().Count == index) return;
            _idsp = Guid.Parse(dgridDSSanPham.Rows[index].Cells[0].Value.ToString());
            var SP = _cTSanPhamService.GetAll().FirstOrDefault(c => c.IdChiTietSP == _idsp);
            txtTenSP.Text = SP.TenSp;
            txtDonGia.Text = SP.GiaBan.ToString();
            txtTenSP.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            btnThemSP.Visible = true;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            var editsp = _cTSanPhamService.GetEdit(_idsp);
            for (int i = 0; i < dgridGioHang.RowCount - 1; i++)
            {
                Guid idhd = Guid.Parse(dgridGioHang.Rows[i].Cells[0].Value.ToString());
                if (_cTHoaDonService.GetEdit(idhd).IdChiTietSP == _idsp)
                {
                    MessageBox.Show("Sản phẩm đã có trong giỏ hàng");
                    return;
                }
            }
            if (txtSoLuong.Text == "") MessageBox.Show("Chưa nhập số lượng");
            else
            {
                editsp.SoLuong = editsp.SoLuong - int.Parse(txtSoLuong.Text);
                _cTSanPhamService.Update(editsp);
                _cTHoaDonService.Add(GetEditCTHoaDonView(editsp));
                LoadDSSanPham();
                LoadGioHang();
                ClearSl();
            }
        }
        public EditCTHoaDonView GetEditCTHoaDonView(EditCTSanPhamView editsp)
        {
            var hd = _hoaDonService.GetEdit(_idkh);
            return new EditCTHoaDonView() { IdHoaDon = hd.IdHoaDon, IdChiTietSP = editsp.IdChiTietSP, DonGia = editsp.GiaBan, SoLuongMua = int.Parse(txtSoLuong.Text) };
        }
        private void dgridGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || _cTHoaDonService.GetAll().Count == index) return;
            _idgh = Guid.Parse(dgridGioHang.Rows[index].Cells[0].Value.ToString());
            var SP = _cTHoaDonService.GetAll().FirstOrDefault(c => c.IdCTHoaDon == _idgh);
            txtTenSP.Text = SP.TenSp;
            txtDonGia.Text = SP.DonGia.ToString();
            txtTenSP.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            btnThemSP.Visible = false;
        }
        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            var edithdct = _cTHoaDonService.GetEdit(_idgh);
            edithdct.SoLuongMua = int.Parse(txtSoLuong.Text);
            _cTHoaDonService.Update(edithdct);
            LoadGioHang();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgridGioHang.Rows[0].Cells[0].Value == null || txtDCNhan.Text == "")
            {
                MessageBox.Show("Chưa đủ thông tin");
            }
            else
            {
                this.Hide();
                var kh = _khachHangService.GetEdit(_idkh);
                kh.DCNhanHang = txtDCNhan.Text;
                kh.NgayNhan = dateNgayNhan.Value;
                _khachHangService.Update(kh);
                FrmThanhToan frmtt = new FrmThanhToan(_idkh);
                frmtt.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var edithdct = _cTHoaDonService.GetEdit(_idgh);
            edithdct.IdCTHoaDon = _idgh;
            edithdct.SoLuongMua = int.Parse(txtSoLuong.Text);
            _cTHoaDonService.Delete(edithdct);
            LoadGioHang();
            ClearSl();
        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            LoadDSSanPham();
            loadKH();
            LoadGioHang();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (dgridGioHang.Rows[0].Cells[0].Value == null) return;
                else
                {
                    Guid idcthd = Guid.Parse(dgridGioHang.Rows[0].Cells[0].Value.ToString());
                    var cthd = _cTHoaDonService.GetEdit(idcthd);
                    _cTHoaDonService.Delete(cthd);
                    LoadGioHang();
                    ClearSl();
                }
            }
        }
        public void ClearSl()
        {
            txtSoLuong.Text = "";
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void cmbLocLsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocLsp.Text == "Lọc Theo Loại Sản Phẩm")
            {
                LoadDSSanPham();
            }
            else if (cmbDanhMuc.Text != "Lọc Theo Danh Mục" && cmbLocLsp.Text != "Lọc Theo Loại Sản Phẩm")
            {
                dgridDSSanPham.Rows.Clear();
                List<CTSanPhamView> lstctsp = (from a in _cTSanPhamService.GetAll()
                                               where a.TenDanhMuc == cmbDanhMuc.Text && a.TenLoaiSp == cmbLocLsp.Text
                                               select new CTSanPhamView()
                                               {
                                                   IdChiTietSP = a.IdChiTietSP,
                                                   TenSp = a.TenSp,
                                                   TenLoaiSp = a.TenLoaiSp,
                                                   GiaBan = a.GiaBan,
                                                   SoLuong = a.SoLuong,
                                                   GiaNhap = a.GiaNhap,
                                                   TenNhaCungCap = a.TenNhaCungCap,
                                                   TenDanhMuc = a.TenDanhMuc,
                                                   TenDonVi = a.TenDonVi
                                               }).ToList();
                foreach (var x in lstctsp)
                {
                    dgridDSSanPham.Rows.Add(
                        x.IdChiTietSP,
                        x.TenSp,
                        x.TenLoaiSp,
                        x.GiaBan,
                        x.SoLuong,
                        x.GiaNhap,
                        x.TenNhaCungCap,
                        x.TenDanhMuc,
                        x.TenDonVi
                        );
                }
            }
            else
            {
                dgridDSSanPham.Rows.Clear();
                foreach (var x in _cTSanPhamService.GetAll().Where(c => c.TenLoaiSp == cmbLocLsp.Text))
                {
                    dgridDSSanPham.Rows.Add(
                        x.IdChiTietSP,
                        x.TenSp,
                        x.TenLoaiSp,
                        x.GiaBan,
                        x.SoLuong,
                        x.GiaNhap,
                        x.TenNhaCungCap,
                        x.TenDanhMuc,
                        x.TenDonVi
                        );
                }
            }
        }

        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDanhMuc.Text == "Lọc Theo Danh Mục")
            {
                LoadDSSanPham();
            }
            else if (cmbDanhMuc.Text != "Lọc Theo Danh Mục" && cmbLocLsp.Text != "Lọc Theo Loại Sản Phẩm")
            {
                dgridDSSanPham.Rows.Clear();
                List<CTSanPhamView> lstctsp = (from a in _cTSanPhamService.GetAll()
                                               where a.TenDanhMuc == cmbDanhMuc.Text && a.TenLoaiSp == cmbLocLsp.Text
                                               select new CTSanPhamView()
                                               {
                                                   IdChiTietSP=a.IdChiTietSP,
                                                   TenSp=a.TenSp,
                                                   TenLoaiSp=a.TenLoaiSp,
                                                   GiaBan=a.GiaBan,
                                                   SoLuong=a.SoLuong,
                                                   GiaNhap=a.GiaNhap,
                                                   TenNhaCungCap=a.TenNhaCungCap,
                                                   TenDanhMuc=a.TenDanhMuc,
                                                   TenDonVi=a.TenDonVi
                                               }).ToList();
                foreach (var x in lstctsp)
                {
                    dgridDSSanPham.Rows.Add(
                        x.IdChiTietSP,
                        x.TenSp,
                        x.TenLoaiSp,
                        x.GiaBan,
                        x.SoLuong,
                        x.GiaNhap,
                        x.TenNhaCungCap,
                        x.TenDanhMuc,
                        x.TenDonVi
                        );
                }
            }
            else
            {
                dgridDSSanPham.Rows.Clear();
                foreach (var x in _cTSanPhamService.GetAll().Where(c => c.TenDanhMuc == cmbDanhMuc.Text))
                {
                    dgridDSSanPham.Rows.Add(
                        x.IdChiTietSP,
                        x.TenSp,
                        x.TenLoaiSp,
                        x.GiaBan,
                        x.SoLuong,
                        x.GiaNhap,
                        x.TenNhaCungCap,
                        x.TenDanhMuc,
                        x.TenDonVi
                        );
                }
            }
        }
        public void LoadLoc()
        {
            cmbDanhMuc.Items.Add("Lọc Theo Danh Mục");
            cmbLocLsp.Items.Add("Lọc Theo Loại Sản Phẩm");
            foreach (var x in _cTSanPhamService.GetAll())
            {
                cmbDanhMuc.Items.Add(x.TenDanhMuc);
            }
            foreach (var x in _cTSanPhamService.GetAll())
            {
                cmbLocLsp.Items.Add(x.TenLoaiSp);
            }
            cmbLocLsp.SelectedIndex = 0;
            cmbDanhMuc.SelectedIndex = 0;
        }
    }
}
