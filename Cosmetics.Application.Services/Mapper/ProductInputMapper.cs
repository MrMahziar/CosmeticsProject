using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Mapper
{
   public class ProductInputMapper:Profile
    {
        public ProductInputMapper()
        {
            CreateMap<Product, ProductInputDto>();
        }

    }
}
