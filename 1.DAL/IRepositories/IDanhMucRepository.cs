using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IDanhMucRepository
    {
        public bool Add(DanhMuc obj);
        public bool Update(DanhMuc obj);
        public bool Delete(DanhMuc obj);
        public List<DanhMuc> GetAll();
    }
}
