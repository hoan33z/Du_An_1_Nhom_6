using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IDonViService
    {
        public string Add(DonVi obj);
        public string Update(DonVi obj);
        public string Delete(DonVi obj);
        public List<DonVi> GetAll();
    }
}
