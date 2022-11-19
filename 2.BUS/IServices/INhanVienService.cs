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
        public string Add(NhanVien obj);
        public string Update(NhanVien obj);
        public string Delete(NhanVien obj);
        public List<NhanVien> GetAll();
    }
}
