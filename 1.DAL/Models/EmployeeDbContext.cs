using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext()
        {

        }
        
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Fresher> Freshers { get; set; }
        public virtual DbSet<Intern> Interns { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public  EmployeeDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Thực hiện các ràng buộc kết nối
            base.OnConfiguring(optionsBuilder.
                UseSqlServer("Data Source=DUONG1A2B\\SQLEXPRESS;Initial Catalog=Test;" +
                "Persist Security Info=True;User ID=DuongNhanChinh;Password=duong1a2b"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Phương thức này sẽ áp dụng tất cả các config hiện có
        }
    }
}
