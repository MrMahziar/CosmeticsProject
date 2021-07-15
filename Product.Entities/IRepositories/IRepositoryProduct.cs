using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Entities.IRepositories
{
    public interface IRepositoryProduct
    {
        void Insert(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        ValueTask<Product> GetAsync(int id);
        Task<List<Product>> GetAllProductAsync();
        IQueryable GetQueryable();
    }
}
