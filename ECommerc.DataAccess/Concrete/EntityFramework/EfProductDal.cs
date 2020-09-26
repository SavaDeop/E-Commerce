using ECommerc.Core.DataAccess.EntityFramework;
using ECommerc.DataAccess.Abstract;
using ECommerc.DataAccess.Context;
using ECommerc.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerc.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepository<Products, MyContext>, IProductDal
    {
    }
}
