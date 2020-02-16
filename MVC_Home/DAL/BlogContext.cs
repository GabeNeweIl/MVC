using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCHome.DAL.Data;

namespace MVCHome.DAL
{
    public class BlogContext : DbContext
    {
        public BlogContext(string connectionString)
            : base(connectionString) { }
       
        public BlogContext() : base("Blog") { }
        public DbSet<Artiсle> Articles { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}