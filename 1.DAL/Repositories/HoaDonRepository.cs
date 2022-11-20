using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        VatLieuDbContext _vatLieuDbContext;
        public HoaDonRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.HoaDons.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.HoaDons.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            _vatLieuDbContext.HoaDons.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _vatLieuDbContext.HoaDons.ToList();
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.HoaDons.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.NgayNhan = obj.NgayNhan;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.TongTien = obj.TongTien;
            tempobj.IdNhanVien = obj.IdNhanVien;
            tempobj.IdKhachHang = obj.IdKhachHang;
            _vatLieuDbContext.HoaDons.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
