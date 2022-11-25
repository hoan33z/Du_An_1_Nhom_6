using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INhanVienService
    {
        public string AddNV(NhanVien _nv);


        public List<NhanVien> getlstNv();


        public List<NhanVien> TimKiem(string text);

        public string UpdateNV(NhanVien _nv);


        public string DeleteNV(NhanVien _nv);

    }
}
