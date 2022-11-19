using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICTSanPhamService
    {
        public string Add(CTSanPhamView obj);
        public string Update(CTSanPhamView obj);
        public string Delete(CTSanPhamView obj);
        public List<CTSanPhamView> GetAll();

    }
}
