using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEFExpress.Models
{
    public class MyContent : DbContext
    {
        public DbSet<Category> CategorySet { get; set; }
        public DbSet<Data> ContactSet { get; set; }

        public MyContent()
        {

        }
    }
}
