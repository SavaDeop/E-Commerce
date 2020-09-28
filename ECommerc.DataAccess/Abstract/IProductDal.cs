using ECommerc.Core.DataAccess;
using ECommerc.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerc.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Products>
    {
        public IEnumerable<Products> GetProducts();
    }
}
