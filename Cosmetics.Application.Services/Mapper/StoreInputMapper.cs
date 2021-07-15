using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class StoreInputMapper:Profile
    {
        public StoreInputMapper()
        {
            CreateMap<Store, StoreInputDto>();
        }
    }
}
