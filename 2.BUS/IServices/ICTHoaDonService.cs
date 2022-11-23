using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICTHoaDonService
    {
        public string Add(EditCTHoaDonView obj);
        public string Update(EditCTHoaDonView obj);
        public string Delete(EditCTHoaDonView obj);
        public List<CTHoaDonView> GetAll();
        public EditCTHoaDonView GetEdit(Guid id);
    }
}
