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
    public class EfProductDal : EfEntityRepository<Products, MyContext>, IProductDal
    {
        public IEnumerable<Products> GetProducts()
        {
            using var context = new MyContext();
            var contexts = context.Set<Products>()
                .Include("Company.Products")
                .Include("Category.Products")
                .AsQueryable();
            
            return contexts.ToList();
        }
    }
}
