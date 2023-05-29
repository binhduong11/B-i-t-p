using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _1.DAL.Irepositories;
using _1.DAL.Repositories;
using _2.BUS.Iservices;

namespace _2.BUS.Services
{
    public class Experience_Services:ExperienceIServices
    {
        //private Irepositories<Employee> _Employeerepos;
        private EmployeeDbContext EmployeeDbContext = new EmployeeDbContext();
        private Irepositories<Experience> _ExperienceRepos;
        private Experience_Irepositories _irepos;
        public Experience_Services()
        {
            //Repositories<Employee> _repositorie = new Repositories<Employee>(EmployeeDbContext, EmployeeDbContext.Employees);
            //_Employeerepos = _repositorie;
            Repositories<Experience> _repositorie2 = new Repositories<Experience>(EmployeeDbContext, EmployeeDbContext.Experiences);
            _ExperienceRepos = _repositorie2;
            _irepos = new Experience_repos();
        }

        public string Add(Employee obj, int ExpInYear, string ProSkill)
        {
            Experience experience = new Experience();
            experience.ID = obj.ID;
            experience.FullName = obj.FullName;
            experience.Email = obj.Email;
            experience.ExpInYear = ExpInYear;
            experience.ProSkill = ProSkill;
            experience.BirthDay = obj.BirthDay;
            experience.Phone = obj.Phone;
            experience.Employee_count = obj.Employee_count;
            experience.Employee_type = obj.Employee_type;

            if (_ExperienceRepos.Create(experience))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thêm thất bại";

            }
            

        }

        public string Delete(Experience obj)
        {
            throw new NotImplementedException();
        }

        public List<Experience> GetAll()
        {
            throw new NotImplementedException();
        }

        public string ShowInfor(int id)
        {
            throw new NotImplementedException();
        }

        public string ShowMe(int id)
        {
            throw new NotImplementedException();
        }

        public string Update(Experience obj)
        {
            throw new NotImplementedException();
        }
    }
}
