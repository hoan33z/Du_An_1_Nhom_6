using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ITaiKhoan
    {
        public bool Add(TaiKhoan obj);
        public bool Update(TaiKhoan obj);
        public bool Delete(TaiKhoan obj);
        public List<TaiKhoan> GetAll();
    }
}
