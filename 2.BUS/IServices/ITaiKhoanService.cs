using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ITaiKhoanService
    {
        public string Add(TaiKhoan obj);
        public string Update(TaiKhoan obj);
        public string Delete(TaiKhoan obj);
        public List<TaiKhoan> GetAll();
    }
}
