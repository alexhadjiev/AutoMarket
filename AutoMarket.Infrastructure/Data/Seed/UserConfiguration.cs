using Microsoft.AspNetCore.Identity;
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
    internal class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
       
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var users = SeedUsers();
            builder.HasData(users);
        }

        public static IdentityUser[] SeedUsers() 
        {
            var hasher = new PasswordHasher<IdentityUser>();

            IdentityUser sellerUser = new IdentityUser()
            {
                Id = "dae12856-c198-4129-b3f3-b893d8395082",
                UserName = "seller@mail.com",
                NormalizedUserName = "seller@mail.com",
                Email = "seller@mail.com",
                NormalizedEmail = "seller@mail.com"
            };

            sellerUser.PasswordHash =
                 hasher.HashPassword(sellerUser, "seller123");

            IdentityUser guestUser = new IdentityUser()
            {
                Id = "7d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            guestUser.PasswordHash =
            hasher.HashPassword(guestUser, "guest123");

            IdentityUser[] users = { sellerUser, guestUser };

            return users;
        }
    }
}
