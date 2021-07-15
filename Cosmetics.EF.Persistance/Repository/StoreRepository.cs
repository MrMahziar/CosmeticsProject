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
    public class StoreRepository : IRepositoryStore
    {
        private readonly AppDBContext dBContext;

        public StoreRepository(AppDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task DeleteAsync(int id)
        {
            var store = await dBContext.Stores.FindAsync(id);
            if (store == null)
            {
                throw new FileNotFoundException();
            }
            dBContext.Stores.Remove(store);
        }

        public Task<List<Store>> GetAllStoreAsync()
        {
            return dBContext.Stores.ToListAsync();
        }

        public async ValueTask<Store> GetAsync(int id)
        {
            var store = await dBContext.Stores.FindAsync(id);
            if (store == null)
            {
                throw new FileNotFoundException();
            }
            return store;
        }

        public IQueryable GetQueryable()
        {
            return dBContext.Stores.AsQueryable();
        }

        public void Insert(Store store)
        {
            dBContext.Stores.Add(store);
        }

        public async Task UpdateAsync(Store store)
        {
            var resultStore = await dBContext.Stores.FindAsync(store.Id);
            if (resultStore == null)
            {
                throw new KeyNotFoundException();
            }
            dBContext.Update(resultStore);
        }
    }
}
