using Microsoft.EntityFrameworkCore;
using Peepy.Ims.EFCore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Peepy.Ims.EFCore
{
    public class PeppyImsContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var file = Path.Combine("PeepyIms.db");
            file = Path.GetFullPath(file);
            optionsBuilder.UseSqlite($"Filename={file}");
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
