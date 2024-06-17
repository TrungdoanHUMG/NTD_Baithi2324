using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTD_Baithi2324.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NTD_Baithi2324.Models.Person> Person { get; set; } = default!;

        public DbSet<NTD_Baithi2324.Models.Student> Student { get; set; } = default!;
    }
