using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhachHangService
    {
        public string Add(EditKhachHangView obj);
        public string Update(EditKhachHangView obj);
        public string Delete(EditKhachHangView obj);
        public List<KhachHangView> GetAll();
        public EditKhachHangView GetEdit(Guid id);


    }
}
