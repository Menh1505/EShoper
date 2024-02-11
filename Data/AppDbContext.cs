using Eshopper.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Eshopper.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach(var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if(tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                } 
            }
        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Color> Colors { set; get; }
        public DbSet<Size> Sizes { set; get; }
    }
}