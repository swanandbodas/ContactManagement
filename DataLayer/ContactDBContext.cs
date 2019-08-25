using DataEntities;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class CMContext : DbContext
    {
        public CMContext()
        {
        }

        public CMContext(DbContextOptions<CMContext> options)
        : base(options) { }
        public DbSet<Contact> Contacts { get; set; }
    }

    //namespace Intro
    //{
    //    public class BloggingContext : DbContext
    //    {
    //        public DbSet<Blog> Blogs { get; set; }
    //        public DbSet<Post> Posts { get; set; }

    //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //        {
    //            optionsBuilder.UseSqlServer(
    //                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
    //        }
    //    }

    //    public class Blog
    //    {
    //        public int BlogId { get; set; }
    //        public string Url { get; set; }
    //        public int Rating { get; set; }
    //        public List<Post> Posts { get; set; }
    //    }

    //    public class Post
    //    {
    //        public int PostId { get; set; }
    //        public string Title { get; set; }
    //        public string Content { get; set; }

    //        public int BlogId { get; set; }
    //        public Blog Blog { get; set; }
    //    }
    //}

}
