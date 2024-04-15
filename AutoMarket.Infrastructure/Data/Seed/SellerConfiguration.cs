using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMarket.Infrastructure.Data.Models;

namespace AutoMarket.Infrastructure.Data.Seed
{
    internal class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.HasData(new Seller
            {
                Id = 1, 
                FullName = "Georgi Georgiev", 
                Email = "seller@mail.com", 
                PhoneNumber = "1234567890" ,
                UserId = "dae12856-c198-4129-b3f3-b893d8395082"

            });
        }
    }
}