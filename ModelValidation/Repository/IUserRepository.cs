using ModelValidation.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModelValidation.Repository
{
    public interface IUserRepository
    {
        Task<UserModel> GetUserAsync(Guid id);
        Task AddUserAsync(UserModel user);
        IEnumerable<UserModel> BrowseAsync();
        Task UpdateAsync(UserModel user);
        long Delete(Guid id);
    }
}
