using ECommerc.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface IProductService
    {
        List<Products> GetAll();
        List<Products> GetByCategory(long categoryId);
        void Add(Products product);
        void Update(Products product);
        void Delete(int productId);
    }
}
