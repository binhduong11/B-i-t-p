using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class Certificate
    {
        public int CertificateID { get; set; }

        public string CertificateName { get; set; }

        public string CertificateRank { get; set; }

        public DateTime CertificatedDate { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee? Employee { get; set; }
        public Certificate()
        {

        }
    }
}
