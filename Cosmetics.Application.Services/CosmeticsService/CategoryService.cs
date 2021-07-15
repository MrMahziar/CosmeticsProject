using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Entities;
using Cosmetics.Entities.IRepositories;

namespace Cosmetics.Application.Services.CosmeticsService
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryCategory repositoryCategory;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryService(IRepositoryCategory repositoryCategory,IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.repositoryCategory = repositoryCategory;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Delete(int id)
        {
            await repositoryCategory.DeleteAsync(id);
            await unitOfWork.Save();
        }

        public async ValueTask<CategoryOutputDto> Get(int id)
        {
            var output = await repositoryCategory.GetAsync(id);
            var category = mapper.Map<CategoryOutputDto>(output);
            return category;
        }

        public async Task<List<CategoryOutputDto>> GetAll()
        {
            var output = await repositoryCategory.GetAllCategoryAsync();
            var category = mapper.Map<List<CategoryOutputDto>>(output);
            return category;
        }

        public async Task Insert(CategoryInputDto categoryDto)
        {
            var input = mapper.Map<Category>(categoryDto);
            repositoryCategory.Insert(input);
           await unitOfWork.Save();
        }

        public async Task Update(CategoryInputDto categoryInputDto)
        {
            var input = mapper.Map<Category>(categoryInputDto);
            await  repositoryCategory.UpdateAsync(input);
            await unitOfWork.Save();
         
        }
    }
}
