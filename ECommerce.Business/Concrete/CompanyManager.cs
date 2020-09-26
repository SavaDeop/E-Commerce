using ECommerc.DataAccess.Abstract;
using ECommerc.Entites.Concrete;
using ECommerce.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _dal;
        public CompanyManager(ICompanyDal dal)
        {
            _dal = dal;
        }
        public void Add(Company company)
        {
            _dal.Add(company);
        }

        public void Delete(int companyId)
        {
            var entity = _dal.Get(x => x.Id == companyId);
            _dal.Delete(entity);
        }

        public List<Company> GetAll()
        {
            return _dal.GetList();
        }

        public void Update(Company company)
        {
            _dal.Update(company);
        }
    }
}
