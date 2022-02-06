using RetailShops.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Repositories.Interfaces
{
    public interface IUserRepository : IRepositoryBase<UserEntity>
    {
        Task<UserEntity> GetUserById(int userId);

        Task<UserEntity> GetUserByName(int userId);


    }
}
