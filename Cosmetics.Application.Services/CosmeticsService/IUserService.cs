using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.CosmeticsService
{
    public  interface IUserService
    {
        Task Insert(UserInputDto  userDto);
        Task Delete(int id);
        Task Update(UserInputDto userInputDto);
        ValueTask<UserOutputDto> Get(int id);
        Task<List<UserOutputDto>> GetAll();
    }

}
