using ECommerc.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerc.Entites.Concrete
{
    public class Category : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Products> Products { get; set; }
    }
}
