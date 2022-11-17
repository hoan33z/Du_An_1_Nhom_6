using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class LoaiTKRepository : ILoaiTK
    {
        VatLieuDbContext _vatLieuDbContext;
        public LoaiTKRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(LoaiTK obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.LoaiTKs.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(LoaiTK obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.LoaiTKs.FirstOrDefault(c => c.IdLoaiTK == obj.IdLoaiTK);
            _vatLieuDbContext.LoaiTKs.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<LoaiTK> GetAll()
        {
            return _vatLieuDbContext.LoaiTKs.ToList();
        }

        public bool Update(LoaiTK obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.LoaiTKs.FirstOrDefault(c => c.IdLoaiTK == obj.IdLoaiTK);
            tempobj.LoaiTk = obj.LoaiTk;
            _vatLieuDbContext.LoaiTKs.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
