using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class StoreOutputMapper:Profile
    {
        public StoreOutputMapper()
        {
            CreateMap<Store, StoreOutputMapper>();
        }
    }
}
