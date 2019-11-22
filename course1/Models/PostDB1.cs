using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace course1.Models
{
    public class PostDB1: DbContext
    {
        public PostDB1(): base("name = PostDB")
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}