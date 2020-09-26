using ECommerc.DataAccess.Abstract;
using ECommerc.Entites.Concrete;
using ECommerce.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _dal;

        public CategoryManager(ICategoryDal dal)
        {
            _dal = dal;
        }

        public void Add(Category category)
        {
            _dal.Add(category);
        }

        public void Delete(long categoryId)
        {
            var entity = _dal.Get(x => x.Id == categoryId);
            _dal.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _dal.GetList();
        }

        public void Update(Category category)
        {
            _dal.Update(category);
        }
    }
}
