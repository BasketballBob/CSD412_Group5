using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GroupAssignment.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; } 
        public DbSet<Page> Pages { get; set; }
        public DbSet<TextContent> TextContents { get; set; }
    }
}
