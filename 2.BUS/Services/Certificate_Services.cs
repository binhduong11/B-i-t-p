using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _1.DAL.Irepositories;
using _1.DAL.Repositories;
using _2.BUS.Iservices;

namespace _2.BUS.Services
{
    public class Certificate_Services : CertificateIServices
    {
        private EmployeeDbContext EmployeeDbContext = new EmployeeDbContext();
        private Irepositories<Certificate> _Irepos;

        public Certificate_Services()
        {

            Repositories<Certificate> _repositorie2 = new Repositories<Certificate>(EmployeeDbContext, EmployeeDbContext.Certificates);
            _Irepos = _repositorie2;

        }
        public string Add(Certificate obj)
        {
            if (_Irepos.Create(obj))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm Thất bại";
            }
        }

        public string Delete(Certificate obj)
        {
            if (_Irepos.Delete(obj))
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa Thất bại";
            }
        }

        public List<Certificate> GetAll()
        {
            return _Irepos.GetAll().ToList();
        }

        public string Update(Certificate obj)
        {
            if (_Irepos.Update(obj))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa Thất bại";
            }
        }
    }
}
