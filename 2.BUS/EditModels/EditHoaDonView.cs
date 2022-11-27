using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class EditHoaDonView
    {
        public Guid IdHoaDon { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }

        public decimal TongTien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThai { get; set; }
    }
}
