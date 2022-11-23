using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class EditKhachHangView
    {
        public Guid IdKhachHang { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int GioiTinh { get; set; }
        public string DCNhanHang { get; set; }
        public DateTime NgayNhan { get; set; }
    }
}
