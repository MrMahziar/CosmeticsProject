using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.EF.Persistance.CosmeticsDatabase;
using Cosmetics.Entities;
using Cosmetics.Entities.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Cosmetics.EF.Persistance.Repository
{
    public class ProductRepository : IRepositoryProduct
    {
        private readonly AppDBContext dBContext;

        public ProductRepository(AppDBContext dBContext,IUnitOfWork unitOfWork)
        {
            this.dBContext = dBContext;
        }
        public async Task DeleteAsync(int id)
        {
            var product = await dBContext.Products.FindAsync(id);
            if(product==null)
            {
                throw new KeyNotFoundException();
            }
            dBContext.Products.Remove(product);
        }

        public Task<List<Product>> GetAllProductAsync()
        {
            return dBContext.Products.ToListAsync();

        }

        public async ValueTask<Product> GetAsync(int id)
        {
            var product = await dBContext.Products.FindAsync(id);
            if (product==null)
            {
                throw new KeyNotFoundException();
            }
            return  product;
        }
        public IQueryable GetQueryable()
        {
            return dBContext.Products.AsQueryable();
        }
        public  void Insert(Product product)
        {
            dBContext.Products.Add(product);
         
        }

        public async Task UpdateAsync(Product product)
        {
            var resultProduct =await dBContext.Products.FindAsync(product.Id);
            if (resultProduct==null)
            {
                throw new KeyNotFoundException();
            }
            dBContext.Update(resultProduct);
            //resultProduct = product;

        }
    }
}
