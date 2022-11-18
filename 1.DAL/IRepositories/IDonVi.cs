using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IDonVi
    {
        public bool Add(DonVi obj);
        public bool Update(DonVi obj);
        public bool Delete(DonVi obj);
        public List<DonVi> GetAll();
    }
}
