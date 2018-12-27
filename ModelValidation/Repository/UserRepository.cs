using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelValidation.Models;

namespace ModelValidation.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiDbContext _context;

        public UserRepository(ApiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UserModel> BrowseAsync() => _context.Users.AsEnumerable();


        public async Task<UserModel> GetUserAsync(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task AddUserAsync(UserModel user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(UserModel user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public long Delete(Guid id)
        {
            var user = GetUserAsync(id).Result;
            if (user == null) return -1;
            _context.Users.Remove(user);
            return _context.SaveChanges();
        }

    }
}
