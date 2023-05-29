using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Irepositories
{
    public interface Experience_Irepositories
    {
        public List<Experience> GetAll();
        public bool Create(Experience item);
        public bool Delete(Experience item);
        public bool Update(Experience item);
    }
}
