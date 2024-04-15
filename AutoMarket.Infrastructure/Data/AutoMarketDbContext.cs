using AutoMarket.Infrastructure.Data.Models;
using AutoMarket.Infrastructure.Data.Seed;
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

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new SellerConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new CarConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Car> Cars { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Seller> Sellers { get; set; } = null!;

        public DbSet<Comment> Comments { get; set; } = null!;

        public DbSet<Favorite> Favorites { get; set; } = null!;
    }

   
}
