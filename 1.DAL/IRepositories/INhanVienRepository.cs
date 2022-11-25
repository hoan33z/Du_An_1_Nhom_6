using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRepository
    {
        public string addNV(NhanVien _nv);
        public List<NhanVien> GetAll();
        public string SuaNV(NhanVien _nv);
        public string XoaNV(NhanVien _nv);

        public List<NhanVien> timKiem(string text);
    }
}
