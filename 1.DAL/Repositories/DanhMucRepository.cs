using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class DanhMucRepository : IDanhMucRepository
    {
        VatLieuDbContext _vatLieuDbContext;
        public DanhMucRepository()
        {
            _vatLieuDbContext= new VatLieuDbContext();
        }
        public bool Add(DanhMuc obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.DanhMucs.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(DanhMuc obj)
        {
            if (obj == null) return false;
            var tempobj =_vatLieuDbContext.DanhMucs.FirstOrDefault(c => c.IdDanhMuc == obj.IdDanhMuc);
            _vatLieuDbContext.DanhMucs.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<DanhMuc> GetAll()
        {
            return _vatLieuDbContext.DanhMucs.ToList();
        }

        public bool Update(DanhMuc obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.DanhMucs.FirstOrDefault(c => c.IdDanhMuc == obj.IdDanhMuc);
            tempobj.TenDanhMuc = obj.TenDanhMuc;
            _vatLieuDbContext.DanhMucs.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
