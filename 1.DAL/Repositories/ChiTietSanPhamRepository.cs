using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ChiTietSanPhamRepository : IChiTietSanPham
    {
        VatLieuDbContext _vatLieuDbContext;
        public ChiTietSanPhamRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(ChiTietSanPham obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.ChiTietSanPhams.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.ChiTietSanPhams.FirstOrDefault(c => c.IdChiTietSP == obj.IdChiTietSP);
            _vatLieuDbContext.ChiTietSanPhams.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<ChiTietSanPham> GetAll()
        {
            return _vatLieuDbContext.ChiTietSanPhams.ToList();

        }

        public bool Update(ChiTietSanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.ChiTietSanPhams.FirstOrDefault(c => c.IdChiTietSP == obj.IdChiTietSP);
            tempobj.Ten = obj.Ten;
            _vatLieuDbContext.ChiTietSanPhams.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
