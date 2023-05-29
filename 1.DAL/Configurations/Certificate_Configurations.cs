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
    internal class Certificate_Configurations : IEntityTypeConfiguration<Certificate>
    {
        void IEntityTypeConfiguration<Certificate>.Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.HasKey(c => c.CertificateID);
            builder.Property(c => c.CertificateName).HasColumnType("nvarchar(50)");
            builder.Property(c => c.CertificateRank).HasColumnType("nvarchar(50)");
            builder.Property(c => c.CertificatedDate).HasColumnType("Datetime");
            builder.HasOne(c => c.Employee).WithMany().HasForeignKey(c => c.EmployeeID);
        }
    }
}

