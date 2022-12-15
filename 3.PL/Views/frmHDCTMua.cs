using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Service;
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
    public partial class frmHDCTMua : Form
    {
        ICTSanPhamService _IcTSanPhamService;
        private VatLieuDbContext _db;
        Guid _idWhenclick;
        Guid _idHoaDon;
        public frmHDCTMua(Guid _idHd)
        {
            InitializeComponent();
            _IcTSanPhamService = new CTSanPhamService();
            _idHoaDon = _idHd;
            _db = new VatLieuDbContext();
            loadData();
            pictureBox1.Enabled = false; ;
            txtGiaBan.Enabled = false;
            txtSoLuong.Enabled = false;
            cmbDanhMuc.Enabled = false;
            cmbLoaiSp.Enabled = false;
            cmbDonVi.Enabled = false;
            cmbNhaCC.Enabled = false;
            cmbTenSP.Enabled = false;
        }
        public void loadData()
        {
            var data = (from ct in _db.ChiTietHoaDons.Where(c => c.IdHoaDon == _idHoaDon)
                        join ctsp in _db.ChiTietSanPhams on ct.IdChiTietSP equals ctsp.IdChiTietSP
                        join sp in _db.SanPhams on ctsp.IdSp equals sp.IdSp
                        select new
                        {
                            idHd = ct.IdHoaDon,
                            idCtSp = ct.IdChiTietSP,
                            tenSp = sp.TenSp,
                            donGia = ct.DonGia,
                            soLuong = ct.SoLuongMua,
                            tongTien = ct.SoLuongMua * ct.DonGia

                        }
                        ).ToList();
            dgridHDCT.ColumnCount = 6;
            dgridHDCT.Columns[0].Name = "IDHoaDon";
            dgridHDCT.Columns[0].Visible = false;
            dgridHDCT.Columns[1].Name = "IdCtSP";
            dgridHDCT.Columns[1].Visible = false;
            dgridHDCT.Columns[2].Name = "Tên sản phẩm";
            dgridHDCT.Columns[3].Name = "Số Lượng Mua";
            dgridHDCT.Columns[4].Name = "Đơn Giá";
            dgridHDCT.Columns[5].Name = "Tổng Tiền";
            dgridHDCT.AllowUserToAddRows = false;
            dgridHDCT.Rows.Clear();
            foreach (var x in data)
            {
                dgridHDCT.Rows.Add(x.idHd, x.idCtSp, x.tenSp, x.soLuong, x.donGia, x.tongTien);
            }
        }
        private void dgridHDCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0) return;
            var row = dgridHDCT.Rows[indexRow];
            _idWhenclick = Guid.Parse(dgridHDCT.Rows[indexRow].Cells[1].Value.ToString());
            var sp = _IcTSanPhamService.GetAll().FirstOrDefault(c => c.IdChiTietSP == _idWhenclick);
            pictureBox1.Image = convertByte(sp.HinhAnh);
            txtGiaBan.Text = row.Cells[4].Value + "";
            txtSoLuong.Text = row.Cells[3].Value + "";
            cmbDanhMuc.Text = sp.TenDanhMuc;
            cmbLoaiSp.Text = sp.TenLoaiSp;
            cmbDonVi.Text = sp.TenDonVi;
            cmbNhaCC.Text = sp.TenNhaCungCap;
            cmbTenSP.Text = sp.TenSp;
        }
        public Image convertByte(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
    }
}
