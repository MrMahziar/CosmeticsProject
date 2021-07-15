using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Entities.IRepositories
{
    public  interface IRepositoryStore
    {
       void Insert(Store store);
       Task UpdateAsync(Store store);
       Task DeleteAsync(int id);
        ValueTask<Store> GetAsync(int id);
        Task<List<Store>> GetAllStoreAsync();
        IQueryable GetQueryable();
    }
}
