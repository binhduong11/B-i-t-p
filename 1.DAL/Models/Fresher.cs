using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class Fresher: Employee// tính kế thừa
    {
       

        public DateTime Graduation_date { get; set; }
        public string Graduation_rank { get; set; }
        public string Education { get; set; }
        public override string ShowInfor()//override(Tính đa hình)
        {
            return "Thông tin nhân viên Fresher =>   Tên: " + FullName + "BirthDay: " + BirthDay + "SDT" + Phone + "Mail" + Email;
        }
        public string ShowInfor(DateTime Graduation_date, string Graduation_rank, string Education)//overloading(Tính đa hình)
        {
            return "Tốt nghiệp: " + Graduation_date.ToString() + "Tốt nghiệp loại: " + Graduation_rank + "Trường tốt nghiệp: " + Education;
        }
    }
}
