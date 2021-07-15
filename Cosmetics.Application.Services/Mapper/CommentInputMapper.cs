using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class CommentInputMapper: Profile
    {
        public CommentInputMapper()
        {
            CreateMap<Comment, CommentInputDto>().ForMember(x => x.Name, o => o.MapFrom(x => x.User.Name))
                                               .ForMember(x => x.Family, o => o.MapFrom(x => x.User.Family));
        }
    }
}
