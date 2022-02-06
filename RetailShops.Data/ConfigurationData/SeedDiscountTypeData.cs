using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailShops.Data.ConfigurationData
{
    public class SeedDiscountTypeData : IEntityTypeConfiguration<DiscountTypeEntity>
    {
        public void Configure(EntityTypeBuilder<DiscountTypeEntity> builder)
        {
            builder.HasData
            (
               new DiscountTypeEntity
               {
                   Id = 1,
                   DiscountTypeName = "AffiliateStore",
                   Rate = 10,
                   IsPercentage = true
               },
                new DiscountTypeEntity
                {
                    Id = 2,
                    DiscountTypeName = "Employee",
                    Rate = 30,
                    IsPercentage = true
                },
                new DiscountTypeEntity
                {
                    Id = 3,
                    DiscountTypeName = "Customer",
                    Rate = 5,
                    IsPercentage = true
                },
                 new DiscountTypeEntity
                 {
                     Id = 4,
                     DiscountTypeName = "Price",
                     Rate = 5,
                     IsPercentage = false
                 }
                 ); 
        }
    }
}
