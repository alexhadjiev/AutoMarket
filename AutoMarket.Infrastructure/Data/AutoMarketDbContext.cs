using AutoMarket.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.Infrastructure.Data
{
    public class AutoMarketDbContext : IdentityDbContext
    {
        public AutoMarketDbContext(DbContextOptions<AutoMarketDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Comment>()
             .HasOne(c => c.Car)
             .WithMany(c => c.Comments)
             .HasForeignKey(c => c.CarId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Car>()
                 .HasOne(c => c.Category)
                 .WithMany(c => c.Cars)
                 .HasForeignKey(c => c.CategoryId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Car>()
               .HasOne(c => c.Seller)
               .WithMany(s => s.Cars)
               .HasForeignKey(c => c.SellerId)
               .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(builder);
        }

        public DbSet<Car> Cars { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Seller> Sellers { get; set; } = null!;

        public DbSet<Comment> Comments { get; set; } = null!;

        public DbSet<Favorite> Favorites { get; set; } = null!;
    }
}
