using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.Iservices
{
    public interface ExperienceIServices//Tính trừu tượng
    {
        public string Add(Employee obj, int ExpInYear, string ProSkill);
        public string Update(Experience obj);
        public string Delete(Experience obj);
        List<Experience> GetAll();
        public string ShowInfor(int id);
        public string ShowMe(int id);
    }
}
