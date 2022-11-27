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
        Guid _id;
        Guid _idnv;
        public FrmDatHang(Guid idnv)
        {
            InitializeComponent();
            _cTSanPhamService = new CTSanPhamService();
            _cTHoaDonService = new CTHoaDonService();
            _hoaDonService = new HoaDonService();
            _khachHangService = new KhachHangService();
            _idnv = idnv;
            LoadDSSanPham();
            loadKH();
            LoadGioHang();
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
            if (_hoaDonService.GetEdit(_idnv) == null) return;
            Guid idkh = _hoaDonService.GetEdit(_idnv).IdKhachHang;
            var kh = _khachHangService.GetAll().FirstOrDefault(c => c.IdKhachHang == idkh);
            txtTenKH.Text = kh.TenKh;
            txtSDT.Text = kh.SDT;
            txtGioiTinh.Text = kh.GioiTinh == 0 ? "nam" : "nu";
            txtDCNhan.Text = kh.DCNhanHang;
            dateNgayNhan.Value = kh.NgayNhan;
        }
        public void LoadGioHang()
        {
            dgridGioHang.ColumnCount = 6;
            dgridGioHang.Columns[0].Name = "IDHD";
            dgridGioHang.Columns[1].Name = "IDKH";
            dgridGioHang.Columns[0].Visible = false;
            dgridGioHang.Columns[1].Visible = false;
            dgridGioHang.Columns[2].Name = "Tên Sản Phẩm";
            dgridGioHang.Columns[3].Name = "Giá Bán";
            dgridGioHang.Columns[4].Name = "Số Lượng";
            dgridGioHang.Columns[5].Name = "Thành Tiền";
            dgridGioHang.Rows.Clear();
            if (_hoaDonService.GetEdit(_idnv) == null) return;
            Guid idkh = _hoaDonService.GetEdit(_idnv).IdKhachHang;
            string tenkh = _khachHangService.GetAll().FirstOrDefault(c => c.IdKhachHang == idkh).TenKh;
            Guid idhd = _hoaDonService.GetAll().FirstOrDefault(c => c.TenKhachHang == tenkh).IdHoaDon;
            foreach (var x in _cTHoaDonService.GetAll().Where(c => c.IdHoaDon == idhd))
            {
                dgridGioHang.Rows.Add(
                    x.IdHoaDon,
                    x.IdCTSP,
                    x.TenSp,
                    x.DonGia,
                    x.SoLuongMua,
                    x.DonGia * x.SoLuongMua
                    );
            }
        }
        private void dgridDSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || _cTSanPhamService.GetAll().Count == index) return;
            _id = Guid.Parse(dgridDSSanPham.Rows[index].Cells[0].Value.ToString());
            var SP = _cTSanPhamService.GetAll().FirstOrDefault(c => c.IdChiTietSP == _id);
            txtTenSP.Text = SP.TenSp;
            txtDonGia.Text = SP.GiaBan.ToString();
            txtTenSP.ReadOnly = true;
            txtDonGia.ReadOnly = true;
        }
        public EditCTHoaDonView GetEditCTHoaDon(EditCTSanPhamView obj)
        {
            return new EditCTHoaDonView() { IdChiTietSP = obj.IdChiTietSP, IdHoaDon = _hoaDonService.GetEdit(_idnv).IdHoaDon, SoLuongMua = int.Parse(txtSoLuong.Text), DonGia = obj.GiaBan };
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            var edit = _cTSanPhamService.GetEdit(_id);
            edit.SoLuong = edit.SoLuong - int.Parse(txtSoLuong.Text);
            _cTSanPhamService.Update(edit);
            _cTHoaDonService.Add(GetEditCTHoaDon(edit));
            LoadDSSanPham();
            LoadGioHang();
        }

        private void dgridGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || _cTSanPhamService.GetAll().Count == index) return;
            _id = Guid.Parse(dgridGioHang.Rows[index].Cells[1].Value.ToString());
            var SP = _cTSanPhamService.GetAll().FirstOrDefault(c => c.IdChiTietSP == _id);
            txtTenSP.Text = SP.TenSp;
            txtDonGia.Text = SP.GiaBan.ToString();
            txtTenSP.ReadOnly = true;
            txtDonGia.ReadOnly = true;
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            var edithdct = _cTHoaDonService.GetEdit(_id);
            edithdct.SoLuongMua = int.Parse(txtSoLuong.Text);
            _cTHoaDonService.Update(edithdct);
            LoadGioHang();
        }
    }
}
