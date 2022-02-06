using RetailShops.Data;
using RetailShops.Domain;
using RetailShops.Domain.Entities;
using RetailShops.Domain.Enums;
using RetailShops.Domain.Shared;
using RetailShops.Infrastructure.Utility;
using RetailShops.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Repositories.Contracts
{
    public class DiscountTypeRepository : RepositoryBase<DiscountTypeEntity>, IDiscountCountRepository
    {

        private readonly ApplicationContextDb _dbContext;


        public DiscountTypeRepository(ApplicationContextDb dbContext)
        : base(dbContext)
        {
            _dbContext = dbContext;
        }


        public string GetDiscountPercentage(DiscountTypeEntity discount)
        {
            throw new NotImplementedException();
        }

        public Task<DiscountTypeEntity> GetDiscountTypeByTypeId(int typeId)
        {
            return _dbContext.Set<DiscountTypeEntity>()
                  .AsNoTracking()
                  .FirstOrDefaultAsync(e => e.Id == typeId);
        }

    }
}
