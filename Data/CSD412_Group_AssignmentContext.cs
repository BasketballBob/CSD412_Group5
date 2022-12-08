using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSD412_Group_Assignment.Models;

namespace CSD412_Group_Assignment.Models
{
    public class CSD412_Group_AssignmentContext : DbContext
    {
        public CSD412_Group_AssignmentContext (DbContextOptions<CSD412_Group_AssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<CSD412_Group_Assignment.Models.User> User { get; set; }

        public DbSet<CSD412_Group_Assignment.Models.Page> Page { get; set; }
    }
}
