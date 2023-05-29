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
    public class Intern_Services : InternIServices
    {
        private EmployeeDbContext EmployeeDbContext = new EmployeeDbContext();
        private Irepositories<Intern> _Irepos;

        public Intern_Services()
        {

            Repositories<Intern> _repositorie2 = new Repositories<Intern>(EmployeeDbContext, EmployeeDbContext.Interns);
            _Irepos = _repositorie2;

        }

        public string Add(Employee obj, string Majors, string Semester, string University_name)
        {
            Intern intern = new Intern();
            intern.ID = obj.ID;
            intern.FullName = obj.FullName;
            intern.BirthDay = obj.BirthDay;
            intern.Phone = obj.Phone;
            intern.Email = obj.Email;
            intern.Employee_count = obj.Employee_count;
            intern.Employee_type = obj.Employee_type;
            intern.Majors = Majors;
            intern.Semester = Semester;
            intern.University_name = University_name;


            if (_Irepos.Create(intern))
            {
                return "Thêm thành công";
            }

            else
            {
                return "Thêm thất bại";
            }
        }

        public string Delete(Intern obj)
        {
            throw new NotImplementedException();
        }

        public List<Intern> GetAll()
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

        public string Update(Intern obj)
        {
            throw new NotImplementedException();
        }
    }
}
