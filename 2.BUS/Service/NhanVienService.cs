using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class NhanVienService : INhanVienService
    {
       
        INhanVienRepository _iNhanVien;
        public NhanVienService()
        {
            _iNhanVien = new NhanVienRepository();
        }
        
        public string AddNV(NhanVien _nv)
        {
            return _iNhanVien.addNV(_nv);
        }

        public List<NhanVien> getlstNv()
        {
            return _iNhanVien.GetAll().ToList();
        }

        public List<NhanVien> TimKiem(string text)
        {
            return _iNhanVien.timKiem(text);
        }

        public string UpdateNV(NhanVien _nv)
        {
            return _iNhanVien.SuaNV(_nv);
        }
        public string DeleteNV(NhanVien _nv)
        {
            return _iNhanVien.XoaNV(_nv);
        }
    }
}
