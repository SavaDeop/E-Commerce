using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerc.DataAccess.Context
{
    public class MyContext : DbContext
    {
        public static string ConnectionString { get; set; }
        public MyContext()
        {
        }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }
    }
}
