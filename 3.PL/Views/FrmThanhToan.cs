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
        Guid _idkh;
        public FrmThanhToan(Guid idkh)
        {
            InitializeComponent();
            _hoaDonService = new HoaDonService();
            _cTHoaDonService = new CTHoaDonService();
            _idkh = idkh;
            loadDonHang();
        }
        public void loadGioHang(List<CTHoaDonView> obj)
        {
            dgridGioHang.ColumnCount = 4;
            dgridGioHang.Columns[0].Name = "Tên Sản Phẩm";
            dgridGioHang.Columns[1].Name = "Giá Bán";
            dgridGioHang.Columns[2].Name = "Số Lượng";
            dgridGioHang.Columns[3].Name = "Thành Tiền";
            dgridGioHang.Rows.Clear();
            foreach (var x in obj)
            {
                dgridGioHang.Rows.Add(x.TenSp, x.DonGia, x.SoLuongMua, x.SoLuongMua * x.DonGia);
            }
        }

        public void loadDonHang()
        {
            dgridHoaDon.ColumnCount = 5;
            dgridHoaDon.Columns[0].Name = "IDHoaDon";
            dgridHoaDon.Columns[1].Name = "Tên Khách hàng";
            dgridHoaDon.Columns[2].Name = "NV Thanh toán";
            dgridHoaDon.Columns[3].Name = "Trạng thái";
            dgridHoaDon.Rows.Clear();
            Guid idhd=_hoaDonService.GetEdit(_idkh).IdHoaDon;
            foreach (var x in _hoaDonService.GetAll().Where(c=>c.IdHoaDon==idhd))
            {
                if (x.TrangThai=true)
                {
                    return;
                }
                else
                {
                    dgridHoaDon.Rows.Add(x.IdHoaDon, x.TenKhachHang, x.TenNhanVien,x.TrangThai==false?"Chưa thanh toán":"Đã thanh toán");
                }
            }
        }
        private void dgridHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || index == _hoaDonService.GetAll().Count) return;
            _id = Guid.Parse(dgridHoaDon.Rows[index].Cells[0].Value.ToString());
            List<CTHoaDonView> lstcthd = (from a in _cTHoaDonService.GetAll()
                                          where a.IdHoaDon == _id
                                          select new CTHoaDonView()
                                          {
                                              TenSp=a.TenSp,
                                              DonGia=a.DonGia,
                                              SoLuongMua=a.SoLuongMua
                                          }).ToList();
            loadGioHang(lstcthd);
           var edithd= _hoaDonService.GetAll().FirstOrDefault(c=>c.IdHoaDon==_id);
            txtNhanVienTT.Text = edithd.TenNhanVien;
            txtTenKH.Text = edithd.TenKhachHang;
            decimal tong=0;
            foreach (var x in lstcthd)
            {
                tong += x.DonGia * x.SoLuongMua;
                txtTongTien.Text = tong.ToString();
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            dgridHoaDon.ColumnCount = 5;
            dgridHoaDon.Columns[0].Name = "IDHoaDon";
            dgridHoaDon.Columns[1].Name = "Tên Khách hàng";
            dgridHoaDon.Columns[2].Name = "NV Thanh toán";
            dgridHoaDon.Columns[3].Name = "Trạng thái";
            dgridHoaDon.Rows.Clear();
            foreach (var x in _hoaDonService.GetAll())
            {
                dgridHoaDon.Rows.Add(x.IdHoaDon, x.TenKhachHang, x.TenNhanVien, x.TrangThai == false ? "Chưa thanh toán" : "Đã thanh toán");
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var editcthd = _hoaDonService.GetEdit(_id);
            editcthd.TrangThai = true;
            _hoaDonService.Update(editcthd);
        }
    }
}
