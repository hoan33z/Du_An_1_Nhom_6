using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class GioHangRepository : IGioHang
    {
        VatLieuDbContext _vatLieuDbContext;
        public GioHangRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }

        public bool Add(GioHang obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.GioHangs.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(GioHang obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.GioHangs.FirstOrDefault(c => c.IdGioHang == obj.IdGioHang);
            _vatLieuDbContext.GioHangs.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<GioHang> GetAll()
        {
            return _vatLieuDbContext.GioHangs.ToList();

        }

        public bool Update(GioHang obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.GioHangs.FirstOrDefault(c => c.IdGioHang == obj.IdGioHang);
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.IdKhachHang = obj.IdKhachHang;
            _vatLieuDbContext.GioHangs.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
