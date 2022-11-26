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
        public EditKhachHangView loadKH()
        {
            var KH = _khachHangService.GetAll().FirstOrDefault(c => c.IdKhachHang == _hoaDonService.GetEdit(_idnv).IdKhachHang);
            if (KH == null)
            {
                return null;
            }
            else
            {
                txtTenKH.Text = KH.TenKh;
                txtSDT.Text = KH.SDT.ToString();
                txtGioiTinh.Text = KH.GioiTinh == 0 ? "Nam" : "Nữ";
                txtTenKH.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtGioiTinh.ReadOnly = true;
                EditKhachHangView editKH = new EditKhachHangView();
                editKH.IdKhachHang= KH.IdKhachHang;
                editKH.DiaChi = KH.DiaChi;
                editKH.TenKh = KH.TenKh;
                editKH.SDT = KH.SDT;
                editKH.DCNhanHang = txtDCNhan.Text;
                editKH.NgayNhan = dateNgayNhan.Value;
                return editKH;
            }
        }
        public void LoadGioHang(string tenkh)
        {
            dgridGioHang.ColumnCount = 5;
            dgridGioHang.Columns[0].Name = "ID";
            dgridGioHang.Columns[0].Visible = false;
            dgridGioHang.Columns[1].Name = "Tên Sản Phẩm";
            dgridGioHang.Columns[2].Name = "Giá Bán";
            dgridGioHang.Columns[3].Name = "Số Lượng";
            dgridGioHang.Columns[4].Name = "Thành Tiền";
            dgridGioHang.Rows.Clear();
            List<CTHoaDonView> lstcthd = (
                from a in _cTHoaDonService.GetAll() 
                join b in _hoaDonService.GetAll() on a.IdHoaDon equals b.IdHoaDon
                where b.TenKhachHang == tenkh
                select new CTHoaDonView()
                {
                    IdHoaDon = a.IdHoaDon,
                    TenSp = a.TenSp,
                    DonGia= a.DonGia,
                    SoLuongMua= a.SoLuongMua,
                    ThanhTien = a.ThanhTien
                }).ToList();
            foreach (var x in lstcthd)
            {
                dgridGioHang.Rows.Add(
                    x.IdHoaDon,
                    x.TenSp,
                    x.DonGia,
                    x.SoLuongMua,
                    x.ThanhTien
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
            return new EditCTHoaDonView() { IdChiTietSP = obj.IdChiTietSP, IdHoaDon = _hoaDonService.GetEdit(_idnv).IdHoaDon, SoLuongMua = int.Parse(txtSoLuong.Text), DonGia = obj.GiaBan, ThanhTien = obj.GiaBan * decimal.Parse(txtSoLuong.Text) };
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            var edit = _cTSanPhamService.GetEdit(_id);
            edit.SoLuong = edit.SoLuong - int.Parse(txtSoLuong.Text);
            _cTSanPhamService.Update(edit);
            _cTHoaDonService.Add(GetEditCTHoaDon(edit));
            _khachHangService.Update(loadKH());
            LoadGioHang(txtTenKH.Text);
            LoadDSSanPham();
        }
    }
}
