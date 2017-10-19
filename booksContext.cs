using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weblab1Forms
{
    class booksContext : DbContext
    {
        
        public booksContext()
                : base("DbConnection")
        { Database.SetInitializer<booksContext>(null); }

        public DbSet<books> books { get; set; }
    }
}
