using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class Experience:Employee// tính kế thừa
    {
        
        public int ExpInYear { get; set; }
        public string ProSkill { get; set; }
        
        
        
        public override string ShowInfor()//override(Tính đa hình)
        {
            return "Thông tin nhân viên Experience =>   Tên: " + FullName + "BirthDay: " + BirthDay + "SDT" + Phone + "Mail" + Email;
        }
        public string ShowInfor(int ExpInYear, string ProSkill)//overloading(Tính đa hình)
        {
            return "Năm kinh nghiệm: " + ExpInYear.ToString() + "Kĩ năng: " + ProSkill;
        }
    }
}
