using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configurations
{
    internal class LoaiTkConfiguration : IEntityTypeConfiguration<LoaiTK>
    {
        public void Configure(EntityTypeBuilder<LoaiTK> builder)
        {
            builder.HasKey(c => c.IdLoaiTK);

            builder.Property(c => c.TenLoaiTk).HasColumnName("TenLoaiTK").HasColumnType("nvarchar(50)").IsRequired();
    
        }
    }
}
