using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BUS.Utilities
{
    public class ReportType
    {
        public string ngaychon;
        public decimal? doanhthu;
        public int sodon;

        public string ngaychon1
        {
            get { return ngaychon; }
        }

        public decimal doanhthu1
        {
            get
            {
                if (this.doanhthu == null)
                    return 0;
                return (decimal)doanhthu;
            }
        }

        public int sodon1
        {
            get { return sodon; }
            set { sodon = value; }
        }
    }

    public class AnalyticsBLL
    {
        private IHoaDonRepository _hd = new HoaDonRepository();
        public List<ReportType> GetAnalyticsByMonth(int month, int year)
        {
            var report = from o in _hd.GetAll()
                         where o.NgayTao.Month == month && o.NgayTao.Year == year
                         group o by new { ngaychon1 = o.NgayTao.Day } into oGroup
                         select new ReportType
                         {
                             ngaychon = oGroup.Key.ngaychon1 + "/" + month + "/" + year,
                             doanhthu = oGroup.Sum(x => x.TongTien),
                             sodon = oGroup.Count(),
                         };
            return report.ToList();
        }

        public List<ReportType> GetAnalyticsByYear(int year)
        {
            var report = from o in _hd.GetAll()
                         where o.NgayTao.Year == year
                         group o by new { ngaychon1 = o.NgayTao.Month } into oGroup
                         select new ReportType
                         {
                             ngaychon = oGroup.Key.ngaychon1 + "/" + year,
                             doanhthu = oGroup.Sum(x => x.TongTien),
                             sodon = oGroup.Count(),
                         };
            return report.ToList();
        }
    }
}
