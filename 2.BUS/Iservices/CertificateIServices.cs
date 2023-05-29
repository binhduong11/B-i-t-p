using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.Iservices
{
    public interface CertificateIServices//Tính trừu tượng
    {
        public string Add(Certificate obj);
        public string Update(Certificate obj);
        public string Delete(Certificate obj);
        List<Certificate> GetAll();
        
    }
}
