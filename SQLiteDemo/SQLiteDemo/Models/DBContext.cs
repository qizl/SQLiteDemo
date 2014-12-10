using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace SQLiteDemo.Models
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
