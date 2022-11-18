using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class DonViRepository : IDonVi
    {
        VatLieuDbContext _vatLieuDbContext;
        public DonViRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(DonVi obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.DonVis.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(DonVi obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.DonVis.FirstOrDefault(c => c.IdDonVi == obj.IdDonVi);
            _vatLieuDbContext.DonVis.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<DonVi> GetAll()
        {
            return _vatLieuDbContext.DonVis.ToList();

        }

        public bool Update(DonVi obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.DonVis.FirstOrDefault(c => c.IdDonVi == obj.IdDonVi);
            tempobj.TenDonVi = obj.TenDonVi;
            _vatLieuDbContext.DonVis.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
