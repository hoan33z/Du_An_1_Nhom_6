using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class VatLieuDbContext : DbContext
    {
        public VatLieuDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.
                UseSqlServer("Data Source=DESKTOP-884QEIL\\SQLEXPRESS;Initial Catalog=Du_An_1_Nhom_6;" +
                "Persist Security Info=True;User ID=hoanltph24402;Password=123456"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
