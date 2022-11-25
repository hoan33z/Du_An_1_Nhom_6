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


        public List<NhanVien> GetAll()
        {
            return _vatLieuDbContext.NhanViens.ToList();
        }


        public string addNV(NhanVien _nv)
        {
            _vatLieuDbContext.Add(_nv);
            _vatLieuDbContext.SaveChanges();
            return "Thêm nhân viên thành công";
        }

        public string SuaNV(NhanVien _nv)
        {
            _vatLieuDbContext.Update(_nv);
            _vatLieuDbContext.SaveChanges();
            return "Sửa thành công";
        }
        public string XoaNV(NhanVien _nv)
        {
            _vatLieuDbContext.Update(_nv);
            _vatLieuDbContext.SaveChanges();
            return "Xóa thành công";
        }




        public List<NhanVien> timKiem(string text)
        {
            return _vatLieuDbContext.NhanViens.Where(c => c.TenNv.Contains(text) || c.SDT.Contains(text) || c.Email.Contains(text) || c.DiaChi.Contains(text)).ToList();
        }
    }
}
