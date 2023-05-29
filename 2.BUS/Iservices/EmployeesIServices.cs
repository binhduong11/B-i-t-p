using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.Iservices
{
    public interface EmployeesIServices//Tính trừu tượng
    {
        public string Add(Employee obj);
        public string Update(Employee obj,int id);
        public string Delete(Employee obj);
        List<Employee> GetAll();
        public string ShowInfor(int id);
        public string ShowMe(int id);
    }
}
