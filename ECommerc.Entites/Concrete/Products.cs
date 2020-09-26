using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ECommerc.Entites.Concrete
{
    public class Products 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        //public virtual Company Company { get; set; }
    }
}
