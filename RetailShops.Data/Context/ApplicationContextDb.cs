using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using RetailShops.Data.ConfigurationData;
using RetailShops.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetailShops.Data
{
    public class ApplicationContextDb : DbContext
    {
        public ApplicationContextDb(DbContextOptions<ApplicationContextDb> options)
            : base(options)
        {
        }

        public DbSet<DiscountTypeEntity> DiscountType { get; set; }
        public DbSet<InvoicesEntity> Invoices { get; set; }
        public DbSet<InvoiceDetailEntity> InvoiceDetails { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UserTypeEntity> UserTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SeedUserData());
            builder.ApplyConfiguration(new SeedUserTypeData());
            builder.ApplyConfiguration(new SeedDiscountTypeData());
            builder.ApplyConfiguration(new SeedInvoiceData());
            builder.ApplyConfiguration(new SeedInvoiceDetailData());
            base.OnModelCreating(builder);
        }
    }
}
