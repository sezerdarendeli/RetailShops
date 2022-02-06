using AutoMapper;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Shared;

namespace RetailShops.Tests
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Maps
            CreateMap<UserEntity, UserResponse>();
            CreateMap<DiscountTypeEntity, DiscountTypesResponse>();
            CreateMap<InvoicesEntity, InvoiceResponse>();
            CreateMap<CreateInvoiceRequest, InvoicesEntity>();
            CreateMap<CreateUserRequest, UserEntity>();
            CreateMap<CreateInvoiceDetailRequest, InvoiceDetailEntity>();
        }
    }
}
