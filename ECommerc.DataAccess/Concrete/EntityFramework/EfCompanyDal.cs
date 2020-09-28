using ECommerc.Core.DataAccess.EntityFramework;
using ECommerc.DataAccess.Abstract;
using ECommerc.DataAccess.Context;
using ECommerc.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerc.DataAccess.Concrete.EntityFramework
{
    public class EfCompanyDal : EfEntityRepository<Company, MyContext>, ICompanyDal
    {
        public IEnumerable<Company> GetCompanies()
        {
            using var context = new MyContext();
            var contexts = context.Set<Company>()
                .Include("Company.Products")
                .Include("Category.Products")
                .AsQueryable();

            return contexts.ToList();
        }
    }
}
