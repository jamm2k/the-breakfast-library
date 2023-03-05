using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheBreakfastLibrary.Models
{
    public class TheBreakfastLibraryContext : DbContext
    {
        public TheBreakfastLibraryContext (DbContextOptions<TheBreakfastLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<TheBreakfastLibrary.Models.Department> Department { get; set; }
    }
}
