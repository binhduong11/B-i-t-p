using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Irepositories
{
    public interface Irepositories<T>//Tính trừu tượng
    {
        public IEnumerable<T> GetAll();
        public bool Create(T item);
        public bool Delete(T item);
        public bool Update(T item);
    }
}
