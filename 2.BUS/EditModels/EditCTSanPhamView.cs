using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class EditCTSanPhamView
    {
        public Guid IdChiTietSP { get; set; }
        public Guid IdLoaiSp { get; set; }
        public Guid IdNhaCungCap { get; set; }
        public Guid IdSp { get; set; }
        public Guid IdDanhMuc { get; set; }
        public Guid IdDonVi { get; set; }

        public byte[] HinhAnh { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public decimal SoLuong { get; set; }
    }
}
