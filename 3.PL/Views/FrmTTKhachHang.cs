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
        public FrmTTKhachHang()
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
            LoadTTKhachHang();
        }
        public KhachHang GetKhachHang()
        {
            return new KhachHang()
            {
                TenKh = txtTenKH.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                GioiTinh = rbtnNam.Checked == true ? 0 : 1,
                DCNhanHang=null,
                NgayNhan=DateTime.Now
            };
        }
        public void LoadTTKhachHang()
        {
            dgridKhachHang.ColumnCount = 7;
            dgridKhachHang.Columns[0].Name = "ID";
            dgridKhachHang.Columns[1].Name = "Tên Khách Hàng";
            dgridKhachHang.Columns[2].Name = "Địa Chỉ";
            dgridKhachHang.Columns[3].Name = "SDT";
            dgridKhachHang.Columns[4].Name = "Giới Tính";
            dgridKhachHang.Columns[5].Name = "DC Nhận Hàng";
            dgridKhachHang.Columns[6].Name = "Ngày Nhận";
            dgridKhachHang.Rows.Clear();
            foreach (var x in _khachHangService.GetAll())
            {
                dgridKhachHang.Rows.Add(x.KhachHangs.IdKhachHang, x.KhachHangs.TenKh, x.KhachHangs.DiaChi, x.KhachHangs.SDT, x.KhachHangs.GioiTinh == 0 ? "Nam" : "Nữ", x.KhachHangs.DCNhanHang, x.KhachHangs.NgayNhan);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditKhachHangView editKH= new EditKhachHangView();
            editKH.KhachHangs = GetKhachHang();
           MessageBox.Show(_khachHangService.Add(editKH));
            LoadTTKhachHang();
        }
    }
}
