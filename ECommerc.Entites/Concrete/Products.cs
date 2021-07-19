using ECommerc.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ECommerc.Entites.Concrete
{
    public class Products : IEntity
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long CompanyId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public long Quantity { get; set; }
        public bool Stock { get; set; }
        public string Photo { get; set; }

        public virtual Company Company { get; set; }
        public virtual Category Category { get; set; }
    }
}
