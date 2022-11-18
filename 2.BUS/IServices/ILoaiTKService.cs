using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ILoaiTKService
    {
        public string Add(LoaiTK obj);
        public string Update(LoaiTK obj);
        public string Delete(LoaiTK obj);
        public List<LoaiTK> GetAll();
    }
}
