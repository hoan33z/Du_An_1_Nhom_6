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
    public partial class FrmThanhToan : Form
    {
        IHoaDonService _hoaDonService;
        ICTHoaDonService _cTHoaDonService;
        Guid _id;
        public FrmThanhToan()
        {
            InitializeComponent();
            _hoaDonService = new HoaDonService();
            _cTHoaDonService = new CTHoaDonService();
            loadDonHang();
        }
        public void loadgiohang(List<CTHoaDonView> obj)
        {
            dgridGioHang.ColumnCount = 4;
            dgridGioHang.Columns[0].Name = "Tên Sản Phẩm";
            dgridGioHang.Columns[1].Name = "Giá Bán";
            dgridGioHang.Columns[2].Name = "Số Lượng";
            dgridGioHang.Columns[3].Name = "Thành Tiền";
            dgridGioHang.Rows.Clear();
            foreach (var x in obj)
            {
                dgridGioHang.Rows.Add(x.TenSp, x.DonGia, x.SoLuongMua, x.ThanhTien);
            }

        }

        public void loadDonHang()
        {
            dgridHoaDon.ColumnCount = 5;
            dgridHoaDon.Columns[0].Name= "IDHoaDon";
            dgridHoaDon.Columns[1].Name= "Tên Khách hàng";
            dgridHoaDon.Columns[2].Name= "Tổng tiền";
            dgridHoaDon.Columns[3].Name= "Ngày thanh toán";
            dgridHoaDon.Columns[4].Name= "NV Thanh toán";
            dgridHoaDon.Rows.Clear();
            foreach (var x in _hoaDonService.GetAll())
            {
                dgridHoaDon.Rows.Add(x.IdHoaDon, x.TenKhachHang, x.TongTien, x.NgayThanhToan, x.TenNhanVien);
            }
        }

        private void dgridGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgridHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || index == _hoaDonService.GetAll().Count) return;
            _id =Guid.Parse( dgridHoaDon.Rows[index].Cells[0].Value.ToString());
            List<CTHoaDonView> lstcthd = (from a in _cTHoaDonService.GetAll()
                                          where a.IdHoaDon == _id
                                          select new CTHoaDonView()
                                          {
                                              DonGia = a.DonGia,
                                              SoLuongMua = a.SoLuongMua,
                                              TenSp = a.TenSp,
                                              ThanhTien = a.ThanhTien
                                          }).ToList();
            loadgiohang(lstcthd);
        }
    }
}
