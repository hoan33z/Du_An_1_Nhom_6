using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class CTSanPhamView
    {
        public Guid IdChiTietSP { get; set; }

        public string TenLoaiSp { get; set; }
        public string TenNhaCungCap { get; set; }
        public string TenSp { get; set; }
        public string TenDanhMuc { get; set; }
        public string TenDonVi { get; set; }

        public byte[] HinhAnh { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
    }
}
