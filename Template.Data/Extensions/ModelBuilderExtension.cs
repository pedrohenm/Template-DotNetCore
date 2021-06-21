using Microsoft.EntityFrameworkCore;
using System;
using Template.Domain.Entities;

namespace Template.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User 
                    { 
                        Id = Guid.Parse("EA972FE2-A22E-478B-A0F7-5A9D569FBB30"), 
                        Name = "User Default", 
                        Email = "userdefault@template.com" 
                    }
                );

            return builder;
        }
    }
}
