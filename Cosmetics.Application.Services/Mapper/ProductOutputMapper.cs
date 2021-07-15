using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class ProductOutputMapper: Profile
    {
        public ProductOutputMapper()
        {
            CreateMap<Product, ProductOutputDto>();
        }
    }
}
