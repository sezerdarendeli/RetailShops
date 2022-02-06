using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailShops.Data.ConfigurationData
{
    public class SeedInvoiceData : IEntityTypeConfiguration<InvoicesEntity>
    {
        public void Configure(EntityTypeBuilder<InvoicesEntity> builder)
        {
            builder.HasData
            (
               new InvoicesEntity
               {
                   Id = 1,
                   InvoiceSerialNumber = "A0001",
                   UserId = (int)UserTypeEnum.Customer,
                   Total = 1000,
               },
                new InvoicesEntity
                {
                    Id = 2,
                    InvoiceSerialNumber = "A0002",
                    UserId = (int)UserTypeEnum.Employee,
                    Total = 1000,
                },
                new InvoicesEntity
                {
                    Id = 3,
                    InvoiceSerialNumber = "A0003",
                    UserId = (int)UserTypeEnum.AffiliateStore,
                    Total = 1000,
                }
            ); 
        }
    }
}
