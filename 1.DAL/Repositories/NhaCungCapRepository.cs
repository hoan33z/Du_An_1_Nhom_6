using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhaCungCapRepository : INhaCungCap
    {
        VatLieuDbContext _vatLieuDbContext;
        public NhaCungCapRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(NhaCungCap obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.NhaCungCaps.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhaCungCap obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.NhaCungCaps.FirstOrDefault(c => c.IdNhaCungCap == obj.IdNhaCungCap);
            _vatLieuDbContext.NhaCungCaps.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<NhaCungCap> GetAll()
        {
            return _vatLieuDbContext.NhaCungCaps.ToList();
        }

        public bool Update(NhaCungCap obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.NhaCungCaps.FirstOrDefault(c => c.IdNhaCungCap == obj.IdNhaCungCap);
            tempobj.TenNhaCungCap = obj.TenNhaCungCap;
            _vatLieuDbContext.NhaCungCaps.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
