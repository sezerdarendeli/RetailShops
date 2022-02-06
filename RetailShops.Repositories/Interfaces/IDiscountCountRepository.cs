using RetailShops.Domain.Entities;
using RetailShops.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Repositories.Interfaces
{
    public interface IDiscountCountRepository : IRepositoryBase<DiscountTypeEntity>
    {

        string GetDiscountPercentage(DiscountTypeEntity discount);
    


        Task<DiscountTypeEntity> GetDiscountTypeByTypeId(int typeId);


    }
}
