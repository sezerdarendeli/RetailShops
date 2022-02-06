using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailShops.Data.ConfigurationData
{
    public class SeedUserData : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasData
            (
                new UserEntity
                {
                    Id = 1,
                    Name = "Sezer",
                    LastName = "Darendeli",
                    Email = "sezer.darendeli@gmail.com",
                    PhoneNumber = "055533322",
                    UserType = (int)UserTypeEnum.Customer,
                    CreatedDate = DateTime.Now
                },
                new UserEntity
                {
                    Id = 2,
                    Name = "Smith",
                    LastName = "Johnson",
                    Email = "simith.johnson@gmail.com",
                    PhoneNumber = "055533322",
                    UserType = (int)UserTypeEnum.AffiliateStore,
                    CreatedDate = DateTime.Now
                },
                new UserEntity
                {
                    Id = 3,
                    Name = "Williams",
                    LastName = "Brown",
                    Email = "williams.brown@gmail.com",
                    PhoneNumber = "055533322",
                    UserType = (int)UserTypeEnum.Employee,
                    CreatedDate = DateTime.Now
                }
            ); 
        }
    }
}
