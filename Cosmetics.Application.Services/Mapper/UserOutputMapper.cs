using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class UserOutputMapper:Profile

    { 
        public UserOutputMapper()
        {
            CreateMap<User, UserOutputDto>();
        }
    }
}
