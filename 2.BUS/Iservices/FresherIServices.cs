using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.Iservices
{
    public interface FresherIServices//Tính trừu tượng
    {
        public string Add(Employee obj, DateTime Graduation_date, string Graduation_rank, string Education);
        public string Update(Fresher obj);
        public string Delete(Fresher obj);
        List<Fresher> GetAll();
        public string ShowInfor();
        public string ShowMe();
    }
}
