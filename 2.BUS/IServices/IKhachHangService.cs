using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhachHangService
    {
        public void Add(KhachHang obj);
        public void Update(KhachHang obj);
        public void Delete(KhachHang obj);
        public List<KhachHang> GetAll();

    }
}
