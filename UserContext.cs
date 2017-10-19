using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace weblab1Forms
{
    namespace weblab1
    {
        class UserContext : DbContext
        {
            public UserContext()
                : base("DbConnection")
            { }
            public DbSet<User> Users { get; set; }
        }
    }

}
