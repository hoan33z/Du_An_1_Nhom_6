using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhaCungCap


                public bool Add(LoaiTK obj);
    public bool Update(LoaiTK obj);
    public bool Delete(LoaiTK obj);
    public List<LoaiTK> GetAll();
}
}
