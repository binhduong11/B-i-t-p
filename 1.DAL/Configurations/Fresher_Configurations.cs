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
    internal class Fresher_Configurations : IEntityTypeConfiguration<Fresher>
    {
        void IEntityTypeConfiguration<Fresher>.Configure(EntityTypeBuilder<Fresher> builder)
        {
           
            builder.Property(c => c.Graduation_date).HasColumnType("Datetime");
            builder.Property(c => c.Graduation_rank).HasColumnType("nvarchar(50)");
            builder.Property(c => c.Education).HasColumnType("nvarchar(50)");
        }
    }
}
