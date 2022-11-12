using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class TaiKhoan
    {
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public Guid IdLoaiTk { get; set; }
        public int TrangThai { get; set; }
        public virtual LoaiTK? LoaiTK { get; set; }
    }
}
