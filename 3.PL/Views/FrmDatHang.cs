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
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            var editsp = _cTSanPhamService.GetEdit(_idsp);
            if (txtSoLuong.Text == "") MessageBox.Show("Chưa nhập số lượng");
            else
            {
                editsp.SoLuong = editsp.SoLuong - int.Parse(txtSoLuong.Text);
                _cTSanPhamService.Update(editsp);
                _cTHoaDonService.Add(GetEditCTHoaDonView(editsp));
                LoadDSSanPham();
                LoadGioHang();
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
        }
        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_idgh.ToString());
            var edithdct = _cTHoaDonService.GetEdit(_idgh);
            edithdct.SoLuongMua = int.Parse(txtSoLuong.Text);
            _cTHoaDonService.Update(edithdct);
            LoadGioHang();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan frmtt = new FrmThanhToan(_idkh);
            frmtt.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var edithdct = _cTHoaDonService.GetEdit(_idgh);
            edithdct.IdCTHoaDon=_idgh;
            edithdct.SoLuongMua = int.Parse(txtSoLuong.Text);
            _cTHoaDonService.Delete(edithdct);
            LoadGioHang();
        }
    }
}
