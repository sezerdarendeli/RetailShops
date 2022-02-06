using AutoMapper;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Shared;
using RetailShops.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailShops.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Maps
            CreateMap<UserEntity,UserResponse>();
            CreateMap<DiscountTypeEntity, DiscountTypesResponse>();
            CreateMap<InvoicesEntity, InvoiceResponse>();
            CreateMap<CreateInvoiceRequest, InvoicesEntity>();
            CreateMap<CreateUserRequest, UserEntity>();

        }
    }
}
