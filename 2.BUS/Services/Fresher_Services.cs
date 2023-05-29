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
    public class Fresher_Services:FresherIServices
    {
        private EmployeeDbContext EmployeeDbContext = new EmployeeDbContext();
        private Irepositories<Fresher> _Irepos;
        
        public Fresher_Services()
        {
            
            Repositories<Fresher> _repositorie2 = new Repositories<Fresher>(EmployeeDbContext, EmployeeDbContext.Freshers);
            _Irepos = _repositorie2;
            
        }

        public string Add(Employee obj, DateTime Graduation_date, string Graduation_rank, string Education)
        {
            Fresher fresher = new Fresher();
            fresher.ID = obj.ID;
            fresher.FullName = obj.FullName;
            fresher.BirthDay = obj.BirthDay;
            fresher.Email = obj.Email;
            fresher.Phone = obj.Phone;
            fresher.Employee_count = obj.Employee_count;
            fresher.Employee_type = obj.Employee_type;
            fresher.Graduation_date = Graduation_date;
            fresher.Graduation_rank = Graduation_rank;
            fresher.Education = Education;
            if (_Irepos.Create(fresher))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string Delete(Fresher obj)
        {
            throw new NotImplementedException();
        }

        public List<Fresher> GetAll()
        {
            throw new NotImplementedException();
        }

        public string ShowInfor()
        {
            throw new NotImplementedException();
        }

        public string ShowMe()
        {
            throw new NotImplementedException();
        }

        public string Update(Fresher obj)
        {
            throw new NotImplementedException();
        }
    }
}
