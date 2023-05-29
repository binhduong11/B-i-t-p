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
    internal class Employee_Configurations : IEntityTypeConfiguration<Employee>
    {
        void IEntityTypeConfiguration<Employee>.Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.FullName).HasColumnType("nvarchar(30)");
            builder.Property(c => c.BirthDay).HasColumnType("Datetime");
            builder.Property(c => c.Phone).HasColumnType("varchar(10)");
            builder.Property(c => c.Email).HasColumnType("varchar(50)");
            builder.Property(c => c.Employee_type).HasColumnType("int");
            builder.Property(c => c.Employee_count).HasColumnType("int");
        }
    }
}
