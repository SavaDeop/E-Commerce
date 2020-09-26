using ECommerc.DataAccess.Abstract;
using ECommerc.Entites.Concrete;
using ECommerce.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _dal;
        public ProductManager(IProductDal dal)
        {
            _dal = dal;
        }

        public void Add(Products product)
        {
            _dal.Add(product);
        }

        public void Delete(int productId)
        {
            var entity = _dal.Get(x => x.Id == productId);
            _dal.Delete(entity);
        }

        public List<Products> GetAll()
        {
            return _dal.GetList();
        }

        public List<Products> GetByCategory(long categoryId)
        {
            return _dal.GetList(x => x.CategoryId == categoryId);
        }

        public void Update(Products product)
        {
            _dal.Update(product);
        }
    }
}
