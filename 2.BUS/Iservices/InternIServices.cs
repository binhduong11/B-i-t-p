using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.Iservices
{
    public interface InternIServices//Tính trừu tượng
    {
        public string Add(Employee obj, string maMajors, string Semester, string University_name);
        public string Update(Intern obj);
        public string Delete(Intern obj);
        List<Intern> GetAll();
        public string ShowInfor();
        public string ShowMe();
    }
}
