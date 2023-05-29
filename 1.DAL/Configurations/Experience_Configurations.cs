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
    internal class Experience_Configurations : IEntityTypeConfiguration<Experience>
    {
        void IEntityTypeConfiguration<Experience>.Configure(EntityTypeBuilder<Experience> builder)
        {
            
            builder.Property(c => c.ExpInYear).HasColumnType("int");
            builder.Property(c => c.ProSkill).HasColumnType("nvarchar(50)");
        }
    }
}
