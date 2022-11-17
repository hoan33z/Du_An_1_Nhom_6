using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class ChiTietSanPham
    {
        public Guid IdChiTietSP { get; set; }
        public Guid IdLoaiSp { get; set; }
        public Guid IdNhaCungCap { get; set; }
        public Guid IdSp { get; set; }
        public Guid IdDanhMuc { get; set; }
        public Guid IdDonVi { get; set; }

        public string Ten { get; set; }
        public string HinhAnh { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public virtual LoaiSp? LoaiSp { get; set; }
        public virtual NhaCungCap? NhaCungCap { get; set; }
        public virtual SanPham? SanPham { get; set; }
        public virtual DanhMuc? DanhMuc { get; set; }
        public virtual DonVi? DonVi { get; set; }
    }
}
