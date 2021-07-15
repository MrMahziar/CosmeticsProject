using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Entities.IRepositories
{
    public interface IRepositoryCategory
    {
        void Insert(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);
        ValueTask<Category> GetAsync(int id);
        Task<List<Category>> GetAllCategoryAsync();
        IQueryable GetQueryable();
    }
}
