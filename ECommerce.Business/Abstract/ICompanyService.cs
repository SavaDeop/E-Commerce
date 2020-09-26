using ECommerc.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetAll();
        void Add(Company company);
        void Update(Company company);
        void Delete(int companyId);
    }
}
