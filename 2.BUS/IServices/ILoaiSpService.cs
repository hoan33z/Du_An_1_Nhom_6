using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ILoaiSpService
    {
        public string Add(LoaiSp obj);
        public string Update(LoaiSp obj);
        public string Delete(LoaiSp obj);
        public List<LoaiSp> GetAll();
    }
}
