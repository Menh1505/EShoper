using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Eshopper.Models;

    public class EShopper : DbContext
    {
        public EShopper (DbContextOptions<EShopper> options)
            : base(options)
        {
        }

        public DbSet<Eshopper.Models.Category> Category { get; set; } = default!;
    }
