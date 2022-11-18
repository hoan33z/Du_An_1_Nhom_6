using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class KhachHangRepository : IKhachHang
    {
        VatLieuDbContext _vatLieuDbContext;
        public KhachHangRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.KhachHangs.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.KhachHangs.FirstOrDefault(c => c.IdKhachHang == obj.IdKhachHang);
            _vatLieuDbContext.KhachHangs.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _vatLieuDbContext.KhachHangs.ToList();

        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.KhachHangs.FirstOrDefault(c => c.IdKhachHang == obj.IdKhachHang);
            tempobj.TenKh = obj.TenKh;
            tempobj.SDT = obj.SDT;
            tempobj.DiaChi = obj.DiaChi;
            _vatLieuDbContext.KhachHangs.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
