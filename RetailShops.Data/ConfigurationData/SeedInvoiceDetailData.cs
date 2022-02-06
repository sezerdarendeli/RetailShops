using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailShops.Data.ConfigurationData
{
    public class SeedInvoiceDetailData : IEntityTypeConfiguration<InvoiceDetailEntity>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetailEntity> builder)
        {
            builder.HasData
            (
               new InvoiceDetailEntity
               {
                   Id = 1,
                   InvoiceId = 1,
                   ProductId = 2,
                   ProductName = "HP Pavilion",
                   ProductPrice = 500,
                   Quantity = 2,
                   CreatedDate =DateTime.Now
               },
                new InvoiceDetailEntity
                {
                    Id = 2,
                    InvoiceId = 2,
                    ProductId = 2,
                    ProductName = "HP Pavilion",
                    ProductPrice = 500,
                    Quantity = 2,
                },
                new InvoiceDetailEntity
                {
                    Id = 3,
                    InvoiceId = 3,
                    ProductId = 2,
                    ProductName = "HP Pavilion",
                    ProductPrice = 500,
                    Quantity = 2,
                }
            ); 
        }
    }
}
