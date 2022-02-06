using RetailShops.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Repositories.Interfaces
{
    public interface IInvoiceRepository : IRepositoryBase<InvoicesEntity>
    {

        Task<InvoicesEntity> GetInvoiceTotal(string serialNumber);
    }
}
