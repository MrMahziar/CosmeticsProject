using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class CommentOutputMapper:Profile
    {
        public CommentOutputMapper()
        {
            CreateMap<Comment, CommentOutputDto>().ForMember(x => x.Name, o => o.MapFrom(x => x.User.Name))
                                                      .ForMember(x => x.Family, o => o.MapFrom(x => x.User.Family));

        }
    }
}
