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
        public string Add(EditCTSanPhamView obj);
        public string Update(EditCTSanPhamView obj);
        public string Delete(EditCTSanPhamView obj);
        public List<CTSanPhamView> GetAll();
        public EditCTSanPhamView GetEdit(Guid id);
         
    }
}
