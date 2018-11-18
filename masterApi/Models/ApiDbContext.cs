using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace masterApi.Models
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext():base("Default")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}