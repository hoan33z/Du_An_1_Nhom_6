using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChiTietGioHangRepository : IChiTietGioHang
    {
        VatLieuDbContext _vatLieuDbContext;
        public ChiTietGioHangRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }

        public bool Add(ChiTietGioHang obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.ChiTietGioHangs.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
        public bool Delete(ChiTietGioHang obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.ChiTietGioHangs.FirstOrDefault(c => c.IdGioHang == obj.IdGioHang);
            _vatLieuDbContext.ChiTietGioHangs.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
        public List<ChiTietGioHang> GetAll()
        {
            return _vatLieuDbContext.ChiTietGioHangs.ToList();
        }
        public bool Update(ChiTietGioHang obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.ChiTietGioHangs.FirstOrDefault(c => c.IdGioHang == obj.IdGioHang);
            tempobj.DonGia = obj.DonGia;
            tempobj.IdChiTietSp=obj.IdChiTietSp;
            tempobj.IdGioHang=obj.IdGioHang;
            _vatLieuDbContext.ChiTietGioHangs.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
