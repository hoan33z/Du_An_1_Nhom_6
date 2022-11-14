using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IDanhMucService
    {
        public string Add(DanhMuc obj);
        public string Update(DanhMuc obj);
        public string Delete(DanhMuc obj);
        public List<DanhMuc> GetAll();
    }
}
