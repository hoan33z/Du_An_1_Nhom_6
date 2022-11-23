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

namespace _3.PL.Views
{
    public partial class FrmDatHang : Form
    {
        ICTSanPhamService _cTSanPhamService;
        ICTHoaDonService _cTHoaDonService;
        IHoaDonService _hoaDonService;
        Guid _id;
        public FrmDatHang()
        {
            InitializeComponent();
            _cTSanPhamService = new CTSanPhamService();
            _cTHoaDonService = new CTHoaDonService();
            _hoaDonService = new HoaDonService();
            LoadDSSanPham();
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
        public void LoadGioHang()
        {
            dgridGioHang.ColumnCount = 5;
            dgridGioHang.Columns[0].Name = "ID";
            dgridGioHang.Columns[0].Visible = false;
            dgridGioHang.Columns[1].Name = "Tên Sản Phẩm";
            dgridGioHang.Columns[2].Name = "Giá Bán";
            dgridGioHang.Columns[3].Name = "Số Lượng";
            dgridGioHang.Columns[4].Name = "Thành Tiền";
            dgridGioHang.Rows.Clear();
            foreach (var x in _cTHoaDonService.GetAll())
            {
                dgridGioHang.Rows.Add(
                    x.IdChiTietSP,
                    x.TenSP,
                    x.DonGia
                    //x.SoLuongMua + txtSoLuong.Text
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
            LoadGioHang();
        }
        public EditCTHoaDonView GetEditCTHoaDon(EditCTSanPhamView obj)
        {
            return new EditCTHoaDonView() { IdChiTietSP = obj.IdChiTietSP, IdHoaDon = Guid.Parse("2ed47fb2-cdbe-408b-89ca-255f2301a924"), SoLuongMua = int.Parse(txtSoLuong.Text), DonGia = obj.GiaBan, ThanhTien = obj.GiaBan * decimal.Parse(txtSoLuong.Text) };
        }
        //public EditHoaDonView getedithoadon()
        //{
        //    return new EditHoaDonView() { IdKhachHang = Guid.Parse("B64431E1-DD74-4159-5E9A-08DACD7E23CA"), IdNhanVien =Guid.Parse("c483503c-ce82-4edd-a234-049adf740b9a"), TongTien = 0, NgayThanhToan = DateTime.Now };
        //}
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            //_hoaDonService.Add(getedithoadon());
            var edit = _cTSanPhamService.GetEdit(_id);
            edit.SoLuong = edit.SoLuong - int.Parse(txtSoLuong.Text);
            _cTSanPhamService.Update(edit);
            //_cTHoaDonService.Add(GetEditCTHoaDon(edit));
            LoadGioHang();
            LoadDSSanPham();
        }
    }
}
