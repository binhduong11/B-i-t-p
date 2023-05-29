using _1.DAL.Irepositories;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Repositories
{
    public class Repositories<T> : Irepositories<T> where T : class
    {
        EmployeeDbContext DBContext;
        DbSet<T> dbset;
        public Repositories()
        {
            DBContext = new EmployeeDbContext();
        }
        public Repositories(EmployeeDbContext context, DbSet<T> dbset)
        {
            this.dbset = dbset;
            this.DBContext = context;
        }
        
        public bool Create(T item)
        {
            try
            {
                dbset.Add(item);
                DBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T item)
        {
            try
            {
                dbset.Remove(item);
                DBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public bool Update(T item)
        {
            try
            {
                dbset.Update(item);
                DBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return true;
            }
        }
    }
}
