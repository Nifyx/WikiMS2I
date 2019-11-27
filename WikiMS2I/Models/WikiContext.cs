using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WikiMS2I.Models.Wiki;

namespace WikiMS2I.Models
{
    public class WikiContext : DbContext
    {
        public WikiContext(DbContextOptions<WikiContext> options) : base(options)
        {
        }

        public DbSet<Content> Contents { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
