using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmThanhToan : Form
    {
        IHoaDonService _hoaDonService;
        ICTHoaDonService _cTHoaDonService;
        Guid _idkh;
        Guid _idhd;
        public FrmThanhToan(Guid idkh)
        {
            InitializeComponent();
            _hoaDonService = new HoaDonService();
            _cTHoaDonService = new CTHoaDonService();
            _idkh = idkh;
            _idhd = _hoaDonService.GetEdit(_idkh).IdHoaDon;
            loadDonHang();
            loadcthd();
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
            dgridHoaDon.Columns[0].Visible = false;
            dgridHoaDon.Columns[1].Name = "Tên Khách hàng";
            dgridHoaDon.Columns[2].Name = "NV Thanh toán";
            dgridHoaDon.Columns[3].Name = "Trạng thái";
            dgridHoaDon.Columns[4].Name = "Tổng Tiền";
            dgridHoaDon.Rows.Clear();
            foreach (var x in _hoaDonService.GetAll().Where(c => c.IdHoaDon == _idhd))
            {
                if (x.TrangThai == true)
                {
                    return;
                }
                else
                {
                    dgridHoaDon.Rows.Add(x.IdHoaDon, x.TenKhachHang, x.TenNhanVien, x.TrangThai == false ? "Chưa thanh toán" : "Đã thanh toán", x.TongTien);
                }
            }
        }
        public void loadcthd()
        {
            List<CTHoaDonView> lstcthd = (from a in _cTHoaDonService.GetAll()
                                          where a.IdHoaDon == _idhd
                                          select new CTHoaDonView()
                                          {
                                              TenSp = a.TenSp,
                                              DonGia = a.DonGia,
                                              SoLuongMua = a.SoLuongMua
                                          }).ToList();
            loadGioHang(lstcthd);
            var edithd = _hoaDonService.GetAll().FirstOrDefault(c => c.IdHoaDon == _idhd);
            txtNhanVienTT.Text = edithd.TenNhanVien;
            txtTenKH.Text = edithd.TenKhachHang;
            decimal tong = 0;
            foreach (var x in lstcthd)
            {
                tong += x.DonGia * x.SoLuongMua;
                txtTongTien.Text = tong.ToString();
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtTienThua.Text == "")
            {
                MessageBox.Show("Chưa Nhập Tiền Để Thanh Toán");
            }
         else   if (int.Parse(txtTienThua.Text) < 0)
            {
                MessageBox.Show("Không Đủ Tiền Để Thanh Toán");
            }
            else
            {
                var editcthd = _hoaDonService.GetEdit(_idhd);
                editcthd.TrangThai = true;
                editcthd.TongTien = decimal.Parse(txtTongTien.Text);
                editcthd.NgayThanhToan = DateTime.Now;
                _hoaDonService.Update(editcthd);
                MessageBox.Show("Đã Thanh Toán");
                this.Hide();
                FrmInHoaDon frmin = new FrmInHoaDon(_idkh);
                frmin.ShowDialog();
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            var editcthd = _hoaDonService.GetEdit(_idhd);
            editcthd.IdHoaDon = _idhd;
            _hoaDonService.Delete(editcthd);
            MessageBox.Show("Đã Hủy");
            this.Hide();
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            loadDonHang();
            loadcthd();
        }
        public void Clear()
        {
            txtNhanVienTT.Text = "";
            txtTenKH.Text = "";
            txtTongTien.Text = "";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            var editcthd = _hoaDonService.GetEdit(_idhd);
            editcthd.TrangThai = false;
            _hoaDonService.Update(editcthd);
            FrmDatHang frmdh = new FrmDatHang(_idkh);
            frmdh.ShowDialog();
        }

        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            if (txtTienKhachTra.Text == "")
            {
                return;
            }
            else
            {
                txtTienThua.Text = (decimal.Parse(txtTienKhachTra.Text) - decimal.Parse(txtTongTien.Text)).ToString();
            }
        }
    }
}
