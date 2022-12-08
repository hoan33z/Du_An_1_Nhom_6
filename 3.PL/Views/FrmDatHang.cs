using _1.DAL.Models;
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
    public partial class FrmDatHang : Form
    {
        ICTSanPhamService _cTSanPhamService;
        ICTHoaDonService _cTHoaDonService;
        IHoaDonService _hoaDonService;
        IKhachHangService _khachHangService;
        INhanVienService _nhanVienService;
        IDanhMucService _danhMucService;
        Guid _idgh;
        Guid _idsp;
        Guid _idnv;
        Guid _idhd;
        public FrmDatHang(Guid id)
        {
            InitializeComponent();
            _cTSanPhamService = new CTSanPhamService();
            _cTHoaDonService = new CTHoaDonService();
            _hoaDonService = new HoaDonService();
            _khachHangService = new KhachHangService();
            _nhanVienService = new NhanVienService();
            _danhMucService = new DanhMucService();
            _idnv = id;
            LoadDSSanPham();
            LoadLoc();
            LoadHoaDon();
        }
        public void LoadDSSanPham()
        {
            dgridDSSanPham.ColumnCount = 8;
            dgridDSSanPham.Columns[0].Name = "ID";
            dgridDSSanPham.Columns[0].Visible = false;
            dgridDSSanPham.Columns[1].Name = "Tên Sản Phẩm";
            dgridDSSanPham.Columns[2].Name = "Loại Sản Phẩm";
            dgridDSSanPham.Columns[3].Name = "Giá Bán";
            dgridDSSanPham.Columns[4].Name = "Số Lượng";
            dgridDSSanPham.Columns[5].Name = "Nhà Cung Cấp";
            dgridDSSanPham.Columns[6].Name = "Danh Mục";
            dgridDSSanPham.Columns[7].Name = "Đơn Vị";
            dgridDSSanPham.Rows.Clear();
            foreach (var x in _cTSanPhamService.GetAll())
            {
                if (x.SoLuong <= 0) return;
                else
                {
                    dgridDSSanPham.Rows.Add(
                        x.IdChiTietSP,
                        x.TenSp,
                        x.TenLoaiSp,
                        x.GiaBan,
                        x.SoLuong,
                        x.TenNhaCungCap,
                        x.TenDanhMuc,
                        x.TenDonVi
                        );
                }
            }
        }
        public void loadKH(Guid idhd)
        {
            if (_khachHangService.GetEdit(_hoaDonService.GetEdit(idhd).IdKhachHang) != null)
            {
                var kh = _khachHangService.GetEdit(_hoaDonService.GetEdit(idhd).IdKhachHang);
                txtTenKH.Text = kh.TenKh;
                txtSDT.Text = kh.SDT;
                txtGioiTinh.Text = kh.GioiTinh == 0 ? "Nam" : "Nữ";
                txtDCNhan.Text = kh.DCNhanHang;
                dateNgayNhan.Value = kh.NgayNhan;
            }
        }
        public void LoadGioHang(Guid idhd)
        {
            dgridGioHang.ColumnCount = 5;
            dgridGioHang.Columns[0].Name = "IDCTHD";
            dgridGioHang.Columns[0].Visible = false;
            dgridGioHang.Columns[1].Name = "Tên Sản Phẩm";
            dgridGioHang.Columns[2].Name = "Giá Bán";
            dgridGioHang.Columns[3].Name = "Số Lượng";
            dgridGioHang.Columns[4].Name = "Thành Tiền";
            dgridGioHang.Rows.Clear();
            if (_hoaDonService.GetEdit(_idnv) != null)
            {
                List<CTHoaDonView> lsteditcthd = (from a in _cTHoaDonService.GetAll() where a.IdHoaDon == idhd select a).ToList();
                foreach (var x in lsteditcthd)
                {
                    dgridGioHang.Rows.Add(x.IdCTHoaDon, x.TenSp, x.DonGia, x.SoLuongMua, x.DonGia * x.SoLuongMua);
                }
            }
            else
            {
                return;
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
            btnSuaTT.Visible = false;
            btnXoa.Visible = false;
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
            else if (_idhd == Guid.Empty || _hoaDonService.GetEdit(_idhd).TrangThai == true)
            {
                return;
            }

            else
            {
                editsp.SoLuong = editsp.SoLuong - decimal.Parse(txtSoLuong.Text);
                _cTSanPhamService.Update(editsp);
                _cTHoaDonService.Add(GetEditCTHoaDonView(editsp));
                LoadDSSanPham();
                LoadGioHang(_idhd);
                ClearSl();
            }
        }
        public EditCTHoaDonView GetEditCTHoaDonView(EditCTSanPhamView editsp)
        {
            var hd = _hoaDonService.GetEdit(_idhd);
            return new EditCTHoaDonView() { IdHoaDon = hd.IdHoaDon, IdChiTietSP = editsp.IdChiTietSP, DonGia = editsp.GiaBan, SoLuongMua = decimal.Parse(txtSoLuong.Text) };
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
            btnSuaTT.Visible = true;
            btnXoa.Visible = true;
            txtSoLuong.Text = SP.SoLuongMua.ToString();

        }
        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            if (_idhd == Guid.Empty || _hoaDonService.GetEdit(_idhd).TrangThai == true)
            {
                return;
            }
            else
            {
                var edithdct = _cTHoaDonService.GetEdit(_idgh);
                var editsp = _cTSanPhamService.GetEdit(_cTHoaDonService.GetEdit(_idgh).IdChiTietSP);
                editsp.SoLuong = editsp.SoLuong + (edithdct.SoLuongMua - decimal.Parse(txtSoLuong.Text));
                _cTSanPhamService.Update(editsp);
                edithdct.SoLuongMua = decimal.Parse(txtSoLuong.Text);
                _cTHoaDonService.Update(edithdct);
                LoadGioHang(_idhd);
                LoadDSSanPham();
                ClearSl();
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgridGioHang.Rows[0].Cells[0].Value == null || txtDCNhan.Text == "")
            {
                MessageBox.Show("Chưa đủ thông tin");
            }
            else if (_hoaDonService.GetEdit(_idhd).TrangThai == true)
            {
                return;
            }
            else
            {
                this.Hide();
                var kh = _khachHangService.GetEdit(_hoaDonService.GetEdit(_idnv).IdKhachHang);
                kh.DCNhanHang = txtDCNhan.Text;
                kh.NgayNhan = dateNgayNhan.Value;
                _khachHangService.Update(kh);
                FrmThanhToan frmtt = new FrmThanhToan(_idnv);
                frmtt.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult lkResult = MessageBox.Show("Bạn có chắc muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (lkResult == DialogResult.Yes)
            {
                if (_hoaDonService.GetEdit(_idhd).TrangThai == true)
                {
                    return;
                }
                else
                {
                    var edithdct = _cTHoaDonService.GetEdit(_idgh);
                    var editsp = _cTSanPhamService.GetEdit(_cTHoaDonService.GetEdit(_idgh).IdChiTietSP);
                    editsp.SoLuong = editsp.SoLuong + decimal.Parse(txtSoLuong.Text);
                    _cTSanPhamService.Update(editsp);
                    _cTHoaDonService.Delete(edithdct);
                    LoadDSSanPham();
                    LoadGioHang(_idhd);
                    ClearSl();
                }
            }
            if (lkResult == DialogResult.No)
            {
                return;
            }
        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            LoadDSSanPham();
            LoadGioHang(_idhd);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (_hoaDonService.GetEdit(_idhd).TrangThai == true)
            {
                return;
            }
            else
            {
                while (dgridGioHang.Rows[0].Cells[0].Value != null)
                {
                    Guid idcthd = Guid.Parse(dgridGioHang.Rows[0].Cells[0].Value.ToString());
                    var cthd = _cTHoaDonService.GetEdit(idcthd);
                    var editsp = _cTSanPhamService.GetEdit(cthd.IdChiTietSP);
                    editsp.SoLuong = editsp.SoLuong + decimal.Parse(dgridGioHang.Rows[0].Cells[3].Value.ToString());
                    _cTSanPhamService.Update(editsp);
                    _cTHoaDonService.Delete(cthd);
                    LoadGioHang(_idhd);
                    ClearSl();
                    LoadDSSanPham();
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
        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDanhMuc.Text == "Lọc Theo Danh Mục")
            {
                LoadDSSanPham();
            }
            else if (cmbDanhMuc.Text != "Lọc Theo Danh Mục")
            {
                dgridDSSanPham.Rows.Clear();
                List<CTSanPhamView> lstctsp = (from a in _cTSanPhamService.GetAll()
                                               where a.TenDanhMuc == cmbDanhMuc.Text
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
        }
        public void LoadLoc()
        {
            cmbDanhMuc.Items.Add("Lọc Theo Danh Mục");
            foreach (var x in _danhMucService.GetAll())
            {
                cmbDanhMuc.Items.Add(x.TenDanhMuc);
            }

            cmbDanhMuc.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                LoadDSSanPham();
            }
            else
            {
                dgridDSSanPham.Rows.Clear();
                foreach (var x in _cTSanPhamService.GetAll().Where(c => c.TenSp.Contains(txtTimKiem.Text)))
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
        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }
        public void LoadHoaDon()
        {
            dgridHoaDon.ColumnCount = 4;
            dgridHoaDon.Columns[0].Name = "IDHoaDon";
            dgridHoaDon.Columns[0].Visible = false;
            dgridHoaDon.Columns[1].Name = "Tên Khách hàng";
            dgridHoaDon.Columns[2].Name = "Trạng thái";
            dgridHoaDon.Columns[3].Name = "Tổng tiền";
            dgridHoaDon.Rows.Clear();
            foreach (var x in _hoaDonService.GetAll().OrderBy(c => c.TrangThai))
            {
                dgridHoaDon.Rows.Add(x.IdHoaDon, x.TenKhachHang, x.TrangThai == false ? "Chưa thanh toán" : "Đã thanh toán", x.TongTien);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_hoaDonService.GetEdit(_idnv) == null)
                {
                    FrmTTKhachHang frm = new FrmTTKhachHang(_idnv);
                    DialogResult frmok = frm.ShowDialog();
                    if (frmok == DialogResult.OK)
                    {
                        LoadHoaDon();
                    }
                }
                else
                {
                    FrmTTKhachHang frm = new FrmTTKhachHang(_idnv);
                    DialogResult frmok = frm.ShowDialog();
                    if (frmok == DialogResult.OK)
                    {
                        LoadHoaDon();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void dgridHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || _hoaDonService.GetAll().Count == index) return;
            _idhd = Guid.Parse(dgridHoaDon.Rows[index].Cells[0].Value.ToString());
            loadKH(_idhd);
            LoadGioHang(_idhd);
        }

        private void FrmDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain(_nhanVienService.getlstNv().FirstOrDefault(c=>c.IdNhanVien==_idnv).Email);
            frm.ShowDialog();
        }
    }
}
