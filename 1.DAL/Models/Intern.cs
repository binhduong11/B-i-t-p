using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class Intern : Employee// tính kế thừa
    {
        

        public string Majors { get; set; } 
        public string Semester { get; set; }
        public string University_name { get; set; }
        public override string ShowInfor()//override(Tính đa hình)
        {
            return "Thông tin nhân viên Intern =>   Tên: " + FullName + "BirthDay: " + BirthDay + "SDT" + Phone + "Mail" + Email;
        }
        public string ShowInfor(string Majors, string Semester, string University_name)//overloading(Tính đa hình)
        {
            return "Chuyên nghành: " + Majors + "Kỳ học: " + Semester + "Trường Trường học: " + University_name;
        }
    }
}
