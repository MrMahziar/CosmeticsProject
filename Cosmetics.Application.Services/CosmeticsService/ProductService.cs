using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Entities;
using Cosmetics.Entities.IRepositories;

namespace Cosmetics.Application.Services.CosmeticsService
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryProduct repositoryProduct;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProductService(IRepositoryProduct repositoryProduct,IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.repositoryProduct = repositoryProduct;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Delete(int id)
        {
           await repositoryProduct.DeleteAsync(id);
           await unitOfWork.Save();
        }

        public async Task<List<ProductOutputDto>> GetAll()
        {
            var output= await repositoryProduct.GetAllProductAsync();
            var product = mapper.Map<List<ProductOutputDto>>(output);
            return product;

        }
        public async ValueTask<ProductOutputDto> Get(int id)
        {
          
            var output = await repositoryProduct.GetAsync(id);
            var product = mapper.Map<ProductOutputDto>(output);
            return product;

        }

        public  async Task Insert(ProductInputDto productDto)
        {
            var input = mapper.Map<Product>(productDto);
            repositoryProduct.Insert(input);
            await unitOfWork.Save();
        }

        public async Task Update(ProductInputDto productInputDto)
        {
          var input = mapper.Map<Product>(productInputDto);
           await repositoryProduct.UpdateAsync(input);
           await unitOfWork.Save();
        }

       
    }
}
