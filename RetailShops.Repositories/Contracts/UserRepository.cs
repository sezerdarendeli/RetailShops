using RetailShops.Data;
using RetailShops.Domain.Entities;
using RetailShops.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Repositories.Contracts
{
    public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
    {
        public UserRepository(ApplicationContextDb dbContext)
      : base(dbContext)
        {

        }

        public Task<UserEntity> GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserByName(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
