using RetailShops.Data;
using RetailShops.Domain.Entities;
using RetailShops.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Repositories.Contracts
{
    public class InvoiceRepository : RepositoryBase<InvoicesEntity>, IInvoiceRepository
    {
        private readonly ApplicationContextDb _dbContext;
        public InvoiceRepository(ApplicationContextDb dbContext)
        : base(dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<InvoicesEntity> GetInvoiceTotal(string serialNumber)
        {
            return await FindByCondition(i => i.InvoiceSerialNumber.Equals(serialNumber)).SingleOrDefaultAsync();
        }

        public IQueryable<InvoicesEntity> FindByCondition(Expression<Func<InvoicesEntity, bool>> expression)
        {
            return _dbContext.Set<InvoicesEntity>().Where(expression).AsNoTracking();
        }
    }
}
