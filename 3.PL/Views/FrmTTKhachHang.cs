using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmTTKhachHang : Form
    {
        IKhachHangService _khachHangService;
        IHoaDonService _hoaDonService;
        Guid _id;
        Guid _idnv;
        public FrmTTKhachHang(Guid id)
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
            _hoaDonService = new HoaDonService();
            _idnv = id;
            LoadTTKhachHang();
        }
        public EditKhachHangView GetKhachHang()
        {
            return new EditKhachHangView()
            {
                IdKhachHang = _id,
                TenKh = txtTenKH.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                GioiTinh = rbtnNam.Checked == true ? 0 : 1,
                DCNhanHang = null,
                NgayNhan = DateTime.Now
            };
        }
        public void LoadTTKhachHang()
        {
            dgridKhachHang.ColumnCount = 5;
            dgridKhachHang.Columns[0].Name = "ID";
            dgridKhachHang.Columns[0].Visible = false;
            dgridKhachHang.Columns[1].Name = "Tên Khách Hàng";
            dgridKhachHang.Columns[2].Name = "Địa Chỉ";
            dgridKhachHang.Columns[3].Name = "SDT";
            dgridKhachHang.Columns[4].Name = "Giới Tính";
            dgridKhachHang.Rows.Clear();
            foreach (var x in _khachHangService.GetAll())
            {
                dgridKhachHang.Rows.Add(x.IdKhachHang, x.TenKh, x.DiaChi, x.SDT, x.GioiTinh == 0 ? "Nam" : "Nữ");
            }
        }
        public EditHoaDonView GetEditHoaDonView()
        {
            return new EditHoaDonView()
            {
                IdKhachHang = _khachHangService.GetAll().FirstOrDefault(c => c.SDT == txtSDT.Text).IdKhachHang,
                IdNhanVien = _idnv,
                TongTien = 0,
                NgayThanhToan = DateTime.Now,
                NgayTao = DateTime.Now,
                TrangThai = false
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtSDT.Text == "" || txtTenKH.Text == "")
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin");
            }
            else if (_khachHangService.GetAll().FirstOrDefault(c => c.SDT == GetKhachHang().SDT) != null)
            {
                MessageBox.Show("Khách Hàng Đã Tồn Tại");
            }
            else
            {
                MessageBox.Show(_khachHangService.Add(GetKhachHang()));
            }
            LoadTTKhachHang();
            ClearForm();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Chưa chọn khách hàng");
            }
            else
            {

                MessageBox.Show(_khachHangService.Update(GetKhachHang()));
            }
            LoadTTKhachHang();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Chưa chọn khách hàng");
            }
            else
            {
                DialogResult lkResult = MessageBox.Show("Bạn có chắc muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo);
                if (lkResult == DialogResult.Yes)
                {
                    MessageBox.Show(_khachHangService.Delete(GetKhachHang()));
                    LoadTTKhachHang();
                    ClearForm();
                }
                if (lkResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Chưa chọn khách hàng");
            }
            else
            {
                _hoaDonService.Add(GetEditHoaDonView());
                MessageBox.Show("Tạo hóa đơn thành công");
                DialogResult = DialogResult.OK;
            }
        }

        private void dgridKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1 || _khachHangService.GetAll().Count == index) return;
            _id = Guid.Parse(dgridKhachHang.Rows[index].Cells[0].Value.ToString());
            var KH = _khachHangService.GetAll().FirstOrDefault(c => c.IdKhachHang == _id);
            txtTenKH.Text = KH.TenKh;
            txtDiaChi.Text = KH.DiaChi;
            txtSDT.Text = KH.SDT;
            rbtnNam.Checked = KH.GioiTinh == 0 ? true : false;
            rbtnNu.Checked = KH.GioiTinh == 1 ? true : false;
        }
        public void ClearForm()
        {
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "") LoadTTKhachHang();
            else
            {
                dgridKhachHang.Rows.Clear();
                foreach (var x in _khachHangService.GetAll().Where(c => c.SDT.Contains(txtTimKiem.Text)))
                {
                    dgridKhachHang.Rows.Add(x.IdKhachHang, x.TenKh, x.DiaChi, x.SDT, x.GioiTinh == 0 ? "Nam" : "Nữ");
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }
    }
}
