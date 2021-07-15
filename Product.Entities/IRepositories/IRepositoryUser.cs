using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Entities.IRepositories
{
    public interface IRepositoryUser
    {
        void Insert(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
        ValueTask<User> GetAsync(int id);
        Task<List<User>> GetAllUserAsync();
        IQueryable GetQueryable();
    }
}
