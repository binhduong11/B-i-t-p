using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class Employee
    {
        

        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay
        {
            get; set;
        }

        public string Phone
        {
            get; set;
        }
        public string Email { get; set; }
        public int Employee_type { get; set; }
        public int Employee_count { get; set; }
        public ICollection<Certificate> Certificate { get; set; }

        public Employee() //contructor không tham số
        {

        }
        public virtual string ShowInfor()
        {
            return "Tên: " + FullName + "BirthDay: " + BirthDay + "SDT: " + Phone + "Mail: " + Email + "Loai: " + Employee_count.ToString();
        }
    }
}
