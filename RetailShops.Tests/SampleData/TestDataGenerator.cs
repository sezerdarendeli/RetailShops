using System;
using System.Collections;
using System.Collections.Generic;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Enums;
using RetailShops.Domain.Shared;

namespace RetailShops.Tests.SampleData
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        public static IEnumerable<object[]> GetUserFromDataGenerator()
        {
            yield return new object[]
            {
            new CreateUserRequest{
                Id = 5,
                Email = "test@test.com",
                LastName = "Example User",
                PhoneNumber = "0533333",
                UserType = (int)UserTypeEnum.Customer,
                CreatedDate = System.DateTime.Now,
            }};

        }



        public static IEnumerable<object[]> GetCreateInvoiceRequestFromDataGeneratorForCustomer()
        {
            yield return new object[]
            {
            new CreateInvoiceRequest{
                 Id = 2,
                OrderTotal = 2000,
                UserId=2,
                InvoiceSerialNumber="A00001",
                CreatedDate=DateTime.Now,
                InvoiceDetails= new List<CreateInvoiceDetailRequest>()
                {
                    new CreateInvoiceDetailRequest
                    {
                        DiscountPrice = 0,
                        Id = 1,
                        InvoiceId = 2,
                        ProductId = 2,
                        ProductPrice = 500,
                        Quantity = 4,
                        ProductName ="Test",
                        CreatedDate=DateTime.Now
                    }
                },
            },
              new UserEntity{
                Id = 2,
                Email = "test@test.com",
                LastName = "Example User",
                PhoneNumber = "0533333",
                UserType = (int)UserTypeEnum.Customer,
                 CreatedDate=DateTime.Now.AddYears(4),
            },
              DiscountTypeList()
             ,
              Convert.ToDecimal(1800)

            };

        }

        /// <summary>
        /// Employee for Dummy Data
        /// </summary>
        /// <returns></returns>
        /// 
        public static IEnumerable<object[]> GetCreateInvoiceRequestFromDataGeneratorForEmployee()
        {
            yield return new object[]
            {
            new CreateInvoiceRequest{
                 Id = 2,
                OrderTotal = 2000,
                UserId=2,
                InvoiceSerialNumber="A00001",
                CreatedDate=DateTime.Now,
                InvoiceDetails= new List<CreateInvoiceDetailRequest>()
                {
                    new CreateInvoiceDetailRequest
                    {
                        DiscountPrice = 0,
                        Id = 1,
                        InvoiceId = 2,
                        ProductId = 2,
                        ProductPrice = 400,
                        Quantity = 20,
                        ProductName ="Test",
                        CreatedDate=DateTime.Now
                    }
                },
            },
              new UserEntity{
                Id = 2,
                Email = "test@test.com",
                LastName = "Example User",
                PhoneNumber = "0533333",
                UserType = (int)UserTypeEnum.Employee,
                CreatedDate = System.DateTime.Now,
            },
              DiscountTypeList()
              ,
              Convert.ToDecimal(1300)

            };

        }

        /// <summary>
        /// AffiliateStore 
        /// </summary>
        /// <returns></returns>
        /// 
        public static IEnumerable<object[]> GetCreateInvoiceRequestFromDataGeneratorForAffiliateStore()
        {
            yield return new object[]
            {
                new CreateInvoiceRequest{
                 Id = 2,
                OrderTotal = 2000,
                UserId=2,
                InvoiceSerialNumber="A00001",
                CreatedDate=DateTime.Now,
                InvoiceDetails= new List<CreateInvoiceDetailRequest>()
                {
                    new CreateInvoiceDetailRequest
                    {
                        DiscountPrice = 0,
                        Id = 1,
                        InvoiceId = 2,
                        ProductId = 2,
                        ProductPrice = 400,
                        Quantity = 20,
                        ProductName ="Test",
                        CreatedDate=DateTime.Now
                    }
                },
            },
              new UserEntity{
                Id = 2,
                Email = "test@test.com",
                LastName = "Example User",
                PhoneNumber = "0533333",
                UserType = (int)UserTypeEnum.AffiliateStore,
                CreatedDate = System.DateTime.Now,
            },
              DiscountTypeList()
              ,
              Convert.ToDecimal(1700)

            };

        }

        public static List<DiscountTypeEntity> DiscountTypeList()
        {
            return new List<DiscountTypeEntity>
              {
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
              };
        }


        public static IEnumerable<object[]> GetInvoiceRequestFromDataGenerator()
        {
            yield return new object[]
            {
            new InvoicesEntity{
                Id = 2,
                OrderTotal = 2,
                UserId=2,
                InvoiceSerialNumber="A00001",
                CreatedDate=DateTime.Now,
                InvoiceDetails= new List<InvoiceDetailEntity>()
                {
                    new InvoiceDetailEntity
                    {
                        DiscountPrice = 0,
                        Id = 1,
                        InvoiceId = 2,
                        ProductId = 2,
                        ProductPrice = 4000,
                        Quantity = 2,
                    }
                },
                Total = 2000
            }};

        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

