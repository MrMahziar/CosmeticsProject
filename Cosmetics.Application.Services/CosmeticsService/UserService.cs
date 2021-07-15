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
    public class UserService : IUserService
    {
        private readonly IRepositoryUser repositoryUser;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UserService(IRepositoryUser repositoryUser, IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.repositoryUser = repositoryUser;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Delete(int id)
        {
            await repositoryUser.DeleteAsync(id);
            await unitOfWork.Save();
        }

        public async ValueTask<UserOutputDto> Get(int id)
        {
            var output = await repositoryUser.GetAsync(id);
            var user= mapper.Map<UserOutputDto>(output);
            return user;
        }

        public async Task<List<UserOutputDto>> GetAll()
        {

            var output = await repositoryUser.GetAllUserAsync();
            var user = mapper.Map<List<UserOutputDto>>(output);
            return user;
        }

        public async Task Insert(UserInputDto userDto)
        {
            var input = mapper.Map<User>(userDto);
            repositoryUser.Insert(input);
            await unitOfWork.Save();
        }

        public async Task Update(UserInputDto userInputDto)
        {
          var input= mapper.Map<User>(userInputDto);
          await  repositoryUser.UpdateAsync(input);
          await unitOfWork.Save();
        }

       
    }
}
