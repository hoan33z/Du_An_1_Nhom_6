using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class FrmTTKhachHang : Form
    {
        IKhachHangService _khachHangService;
        IHoaDonService _hoaDonService;
        Guid _id;
        Guid _idnv;
        public FrmTTKhachHang(Guid idnv)
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
            _hoaDonService = new HoaDonService();
            _idnv = idnv;
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
            dgridKhachHang.ColumnCount = 7;
            dgridKhachHang.Columns[0].Name = "ID";
            dgridKhachHang.Columns[0].Visible = false;
            dgridKhachHang.Columns[1].Name = "Tên Khách Hàng";
            dgridKhachHang.Columns[2].Name = "Địa Chỉ";
            dgridKhachHang.Columns[3].Name = "SDT";
            dgridKhachHang.Columns[4].Name = "Giới Tính";
            dgridKhachHang.Columns[5].Name = "DC Nhận Hàng";
            dgridKhachHang.Columns[6].Name = "Ngày Nhận";
            dgridKhachHang.Rows.Clear();
            foreach (var x in _khachHangService.GetAll())
            {
                dgridKhachHang.Rows.Add(x.IdKhachHang, x.TenKh, x.DiaChi, x.SDT, x.GioiTinh == 0 ? "Nam" : "Nữ", x.DCNhanHang, x.NgayNhan);
            }
        }
        public EditHoaDonView GetEditHoaDonView()
        {
            return new EditHoaDonView()
            {
                IdKhachHang = _khachHangService.GetAll().FirstOrDefault(c=>c.SDT==txtSDT.Text).IdKhachHang,
                IdNhanVien = _idnv,
                TongTien = 0,
                NgayThanhToan = DateTime.Now,
                NgayTao = DateTime.Now,
                TrangThai = false
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_khachHangService.Add(GetKhachHang()));
            LoadTTKhachHang();
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_khachHangService.Update(GetKhachHang()));
            LoadTTKhachHang();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_khachHangService.Delete(GetKhachHang()));
            LoadTTKhachHang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text=="")
            {
                MessageBox.Show("Chưa chọn khách hàng");
            }
            else
            {
                _hoaDonService.Add(GetEditHoaDonView());
                MessageBox.Show("Tạo hóa đơn thành công");
                FrmDatHang frmdh = new FrmDatHang(_id);
                frmdh.ShowDialog();
            }
        }
    }
}
