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
    internal class Intern_Configurations : IEntityTypeConfiguration<Intern>
    {
        void IEntityTypeConfiguration<Intern>.Configure(EntityTypeBuilder<Intern> builder)
        {
           
            builder.Property(c => c.Majors).HasColumnType("nvarchar(50)");
            builder.Property(c => c.Semester).HasColumnType("nvarchar(50)");
            builder.Property(c => c.University_name).HasColumnType("nvarchar(50)");
        }
    }
}
