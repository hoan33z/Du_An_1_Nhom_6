using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class SanPhamRepository : ISanPham
    {
        VatLieuDbContext _vatLieuDbContext;
        public SanPhamRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.SanPhams.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.SanPhams.FirstOrDefault(c => c.IdSp == obj.IdSp);
            _vatLieuDbContext.SanPhams.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _vatLieuDbContext.SanPhams.ToList();
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.SanPhams.FirstOrDefault(c => c.IdSp == obj.IdSp);
            tempobj.TenSp = obj.TenSp;
            _vatLieuDbContext.SanPhams.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
