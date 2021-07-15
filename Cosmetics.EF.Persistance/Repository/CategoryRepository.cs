using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cosmetics.EF.Persistance.CosmeticsDatabase;
using Cosmetics.Entities;
using Cosmetics.Entities.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Cosmetics.EF.Persistance.Repository
{
   public class CategoryRepository : IRepositoryCategory
    {
        private readonly AppDBContext dBContext;

        public CategoryRepository(AppDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task DeleteAsync(int id)
        {
            var category = await dBContext.Categories.FindAsync(id);
            if (category==null)
            {
                throw new FileNotFoundException();
            }
            dBContext.Categories.Remove(category);
        }
        public Task<List<Category>> GetAllCategoryAsync()
        {
            return dBContext.Categories.ToListAsync();
        }

        public async ValueTask<Category> GetAsync(int id)
        {
            var category = await dBContext.Categories.FindAsync(id);
            if (category==null)
            {
                throw new FileNotFoundException();
            }
            return category;
        }

        public IQueryable GetQueryable()
        {
            return dBContext.Categories.AsQueryable();
        }

        public void Insert(Category category)
        {

            dBContext.Categories.Add(category);      
        }

        public async Task UpdateAsync(Category category)
        {
            var resultCategory = await dBContext.Categories.FindAsync(category.Id);
            if (resultCategory == null)
            {
                throw new KeyNotFoundException();
            }
            dBContext.Update(resultCategory);
        }
    }
}
