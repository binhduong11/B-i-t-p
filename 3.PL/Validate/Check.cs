using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _3.PL.Validate
{
    public class Check
    {
        public bool CheckPhone(string sdt)
        {
            if (sdt.Length == 10 && sdt.All(char.IsDigit))
            {
                return true;
            }

            return false;
        }
        public bool CheckMail(string mail)
        {
            string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$";

            if (Regex.IsMatch(mail, emailPattern))
            {
                return true;
            }

            return false;
        }
        public bool CheckBirthDay(DateTime birthday)
        {
            DateTime minValidDate = new DateTime(1900, 1, 1);
            DateTime maxValidDate = DateTime.Now;

            if (birthday >= minValidDate && birthday <= maxValidDate)
            {
                return true;
            }

            return false;
        }
    }
}
