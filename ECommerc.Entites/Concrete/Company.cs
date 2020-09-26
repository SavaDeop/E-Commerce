using ECommerc.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerc.Entites.Concrete
{
    public class Company : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Products> Products { get; set; }
    }
}
