using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChiTietHoaDonRepository : IChiTietHoaDon
    {
        VatLieuDbContext _vatLieuDbContext;
        public ChiTietHoaDonRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(ChiTietHoaDon obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.ChiTietHoaDons.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietHoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.ChiTietHoaDons.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            _vatLieuDbContext.ChiTietHoaDons.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<ChiTietHoaDon> GetAll()
        {
            return _vatLieuDbContext.ChiTietHoaDons.ToList();
        }

        public bool Update(ChiTietHoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.ChiTietHoaDons.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            tempobj.DonGia = obj.DonGia;
            tempobj.IdChiTietSP=obj.IdChiTietSP;
            tempobj.IdHoaDon=obj.IdHoaDon;
            _vatLieuDbContext.ChiTietHoaDons.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
