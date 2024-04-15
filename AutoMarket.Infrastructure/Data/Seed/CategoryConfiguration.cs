using AutoMarket.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.Infrastructure.Data.Seed
{
    internal class CategoryConfiguration :IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder) 
        {
            builder.HasData(
               new Category { Id = 1, Name = "SUV" },
               new Category { Id = 2, Name = "Sedan" },
               new Category { Id = 3, Name = "Truck" },
               new Category { Id = 4, Name = "Sports Car" },
               new Category { Id = 5, Name = "Convertible" },
               new Category { Id = 6, Name = "Hatchback" },
               new Category { Id = 7, Name = "Wagon" },
               new Category { Id = 8, Name = "Electric Car" },
               new Category { Id = 9, Name = "Hybrid Car" },
               new Category { Id = 10, Name = "Bus" }

           );
        }

    }
}
