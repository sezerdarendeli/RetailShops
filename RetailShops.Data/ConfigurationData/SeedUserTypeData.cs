using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailShops.Data.ConfigurationData
{
    public class SeedUserTypeData : IEntityTypeConfiguration<UserTypeEntity>
    {
        public void Configure(EntityTypeBuilder<UserTypeEntity> builder)
        {
            builder.HasData
            (
                new UserTypeEntity
                {
                    Id = 1,
                    TypeName = "Customer"
                },
                new UserTypeEntity
                {
                    Id = 2,
                    TypeName = "Employee"
                },
                new UserTypeEntity
                {
                    Id = 3,
                    TypeName = "AffiliateStore"
                }
            ); 
        }
    }
}
