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
    public partial class FrmQuanLyHoaDon : Form
    {
        
        IHoaDonService _hoaDonService;
        Guid _idHd;
        INhanVienService _inv;

        public FrmQuanLyHoaDon(Guid idnv)
        {
            InitializeComponent();           
            _hoaDonService = new HoaDonService();
            _inv = new NhanVienService();
            var nv = _inv.getlstNv().FirstOrDefault(c => c.IdNhanVien == idnv);

            if (nv.IdLoaiTk == false)
            {
                btnHuy.Hide();
            }
            else
            {
                return;
            }
        }        
        public void loadDonHang()
        {
            dgrid_hoaDon.ColumnCount = 7;
            dgrid_hoaDon.Columns[0].Name = "IDHoaDon";
            dgrid_hoaDon.Columns[0].Visible = false;
            dgrid_hoaDon.Columns[1].Name = "Tên Khách hàng";
            dgrid_hoaDon.Columns[2].Name = "NV Thanh toán";            
            dgrid_hoaDon.Columns[3].Name = "Ngày tạo HD";
            dgrid_hoaDon.Columns[4].Name = "Ngày Thanh Toán";
            dgrid_hoaDon.Columns[5].Name = "Trạng thái";
            dgrid_hoaDon.Columns[6].Name = "Tổng Tiền";
            dgrid_hoaDon.Rows.Clear();
            foreach (var x in _hoaDonService.GetAll())
            {                              
                    dgrid_hoaDon.Rows.Add(x.IdHoaDon, x.TenKhachHang, x.TenNhanVien,x.NgayTao,x.NgayThanhToan, x.TrangThai == false ? "Chưa thanh toán" : "Đã thanh toán", x.TongTien);                
            }
        }
        public void loadDataTimKiem()
        {           
            dgrid_hoaDon.Rows.Clear();
            foreach (var x in _hoaDonService.GetAll().Where(c => c.TenKhachHang.Contains(txt_timKiem.Text)))
            {
                dgrid_hoaDon.Rows.Add(x.IdHoaDon, x.TenKhachHang, x.TenNhanVien, x.NgayTao, x.NgayThanhToan, x.TrangThai == false ? "Chưa thanh toán" : "Đã thanh toán", x.TongTien);
            }
        }

        private void FrmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            loadDonHang();
        }

        private void dgrid_hoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int index = e.RowIndex;
            if (index == -1 || _hoaDonService.GetAll().Count == index) return;
            _idHd = Guid.Parse(dgrid_hoaDon.Rows[index].Cells[0].Value.ToString());
            frmHDCTMua frm = new frmHDCTMua(_idHd);
            frm.ShowDialog();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            loadDataTimKiem();
        }

        private void cbx_trangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_trangThai.Text == "Tất cả")
            {
                loadDonHang();
            }
            else if (cbx_trangThai.Text == "Đã thanh toán")
            {
                dgrid_hoaDon.Rows.Clear();
                foreach (var x in _hoaDonService.GetAll().Where(c => c.TrangThai == true))
                {
                    dgrid_hoaDon.Rows.Add(x.IdHoaDon, x.TenKhachHang, x.TenNhanVien, x.NgayTao, x.NgayThanhToan, x.TrangThai == false ? "Chưa thanh toán" : "Đã thanh toán", x.TongTien);
                }
            }
            else
            {
                dgrid_hoaDon.Rows.Clear();
                foreach (var x in _hoaDonService.GetAll().Where(c => c.TrangThai == false))
                {
                    dgrid_hoaDon.Rows.Add(x.IdHoaDon, x.TenKhachHang, x.TenNhanVien, x.NgayTao, x.NgayThanhToan, x.TrangThai == false ? "Chưa thanh toán" : "Đã thanh toán", x.TongTien);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            var _hoaDon = _hoaDonService.GetEdit(_idHd);
            _hoaDon.IdHoaDon = _idHd;
            _hoaDonService.Delete(_hoaDon);
            MessageBox.Show("Đã Hủy");
            loadDonHang();
        }
    }
}
