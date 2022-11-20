using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IDatHangService
    {
        public string Add(DatHangView obj);
        public string Update(DatHangView obj);
        public string Delete(DatHangView obj);
        public List<DatHangView> GetAll();

    }
}
