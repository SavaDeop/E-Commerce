using ECommerc.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(long categoryId);
    }
}
