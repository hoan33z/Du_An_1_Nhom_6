using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {
        VatLieuDbContext _vatLieuDbContext;
        public NhanVienRepository()
        {
            _vatLieuDbContext = new VatLieuDbContext();
        }
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            _vatLieuDbContext.NhanViens.Add(obj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.NhanViens.FirstOrDefault(c => c.IdNhanVien == obj.IdNhanVien);
            _vatLieuDbContext.NhanViens.Remove(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _vatLieuDbContext.NhanViens.ToList();
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _vatLieuDbContext.NhanViens.FirstOrDefault(c => c.IdNhanVien == obj.IdNhanVien);
            tempobj.TenNv = obj.TenNv;
            tempobj.NamSinh = obj.NamSinh;
            tempobj.GioiTinh = obj.GioiTinh;
            tempobj.Email = obj.Email;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.SDT = obj.SDT;
            _vatLieuDbContext.NhanViens.Update(tempobj);
            _vatLieuDbContext.SaveChanges();
            return true;
        }
    }
}
