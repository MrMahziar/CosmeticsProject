using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.EF.Persistance.CosmeticsDatabase;
using Cosmetics.Entities;
using Cosmetics.Entities.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Cosmetics.EF.Persistance.Repository
{
    public class UserRepository : IRepositoryUser
    {
        private readonly AppDBContext dBContext;

        public UserRepository(AppDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task DeleteAsync(int id)
        {
            var user = await dBContext.Users.FindAsync(id);
            if (user == null)
            {
                throw new FileNotFoundException();
            }
            dBContext.Users.Remove(user);
        }

        public Task<List<User>> GetAllUserAsync()
        {
            return dBContext.Users.ToListAsync();
        }

        public async ValueTask<User> GetAsync(int id)
        {
            var user = await dBContext.Users.FindAsync(id);
            if (user == null)
            {
                throw new FileNotFoundException();
            }
            return user;
        }

        public IQueryable GetQueryable()
        {
            return dBContext.Users.AsQueryable();
        }

        public void Insert(User user)
        {
            dBContext.Users.Add(user);
        }

        public async Task UpdateAsync(User user)
        {
            var resultUser = await dBContext.Users.FindAsync(user.Id);
            if (resultUser == null)
            {
                throw new KeyNotFoundException();
            }
            dBContext.Update(resultUser);
        }
    }
}
