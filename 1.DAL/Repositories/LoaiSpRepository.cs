using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class LoaiSpRepository : ILoaiSp
    {
        VatLieuDbContext _vatLieuDbContext;
        public LoaiSpRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(LoaiSp obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.LoaiSps.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiSp obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.LoaiSps.FirstOrDefault(c => c.IdLoaiSp == obj.IdLoaiSp);
            _vatLieuDbContext.LoaiSps.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<LoaiSp> GetAll()
        {
            return _vatLieuDbContext.LoaiSps.ToList();
        }

        public bool Update(LoaiSp obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.LoaiSps.FirstOrDefault(c => c.IdLoaiSp == obj.IdLoaiSp);
            tempobj.TenLoaiSp = obj.TenLoaiSp;
            _vatLieuDbContext.LoaiSps.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
