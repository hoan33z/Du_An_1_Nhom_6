using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhaCungCap
    {
        public bool Add(NhaCungCap obj);
        public bool Update(NhaCungCap obj);
        public bool Delete(NhaCungCap obj);
        public List<NhaCungCap> GetAll();
    }

}
