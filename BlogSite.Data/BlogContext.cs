using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BlogSite.Entities;

namespace BlogSite.Data
{
    public class BlogContext:DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options):base (options)
        {
            
        }

        public DbSet<BlogSite.Entities.Blog> Blogs { get; set; }

        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
