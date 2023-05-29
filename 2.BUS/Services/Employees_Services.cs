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
    public class Employees_Services : EmployeesIServices
    {
        private Irepositories<Employee> _repositories;
        private EmployeeDbContext _context = new EmployeeDbContext();
        public Employees_Services()
        {
            Repositories<Employee> _repositorie = new Repositories<Employee>(_context,_context.Employees);
            _repositories = _repositorie;
        }
        public string Add(Employee obj)
        {
            if (_repositories.Create(obj))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string Delete(Employee obj)
        {
            if (obj == null) return null;

            if (_repositories.Delete(obj))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }

        public List<Employee> GetAll()
        {
            return _repositories.GetAll().ToList();
        }

        public string ShowInfor(int id)
        {
            Employee x = _repositories.GetAll().First(c=>c.ID == id);
            return x.ShowInfor();
        }

        public string ShowMe(int id)
        {
            throw new NotImplementedException();
        }

        public string Update(Employee obj, int id)
        {
            Employee x = _repositories.GetAll().First(c => c.ID == id);
            x.FullName = obj.FullName;
            x.BirthDay = obj.BirthDay;
            x.Phone = obj.Phone;
            x.Email = obj.Email;
            x.Employee_type = obj.Employee_type;
            x.Employee_count = obj.Employee_count;
            if (_repositories.Update(x))
            {
                return "Sửa thành công";
                
            }
            return "Sửa thất bại";
        }
    }
}
