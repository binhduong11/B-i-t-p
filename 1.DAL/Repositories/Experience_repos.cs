using _1.DAL.Irepositories;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Repositories
{
    public class Experience_repos : Experience_Irepositories
    {
        EmployeeDbContext _DBContext;
        
        public Experience_repos()
        {
            _DBContext = new EmployeeDbContext();
            
        }
        
        
        public bool Create(Experience item)
        {
            try
            {
                _DBContext.Add(item);
                _DBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Experience item)
        {
            try
            {
                _DBContext.Remove(item);
                _DBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Experience> GetAll()
        {
            return _DBContext.Experiences.ToList();
        }

        public bool Update(Experience item)
        {
            try
            {
                _DBContext.Update(item);
                _DBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return true;
            }
        }
    }
}
