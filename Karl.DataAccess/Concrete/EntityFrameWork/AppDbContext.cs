using Karl.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.DataAccess.Concrete.EntityFrameWork
{
    public class AppDbContext : IdentityDbContext<User>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LocalHost;Database=Karl;Trusted_Connection=True;MultipleActiveResultSets=true; TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryLanguage> CategoryLanguages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductLanguage> ProductLanguages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Picture> Pictures { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
        }
    }
}
