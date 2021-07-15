using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Mapper;

namespace Cosmetics.Application.Services.CosmeticsService
{
    public interface ICommentService
    {
        Task Insert(CommentInputDto  commentInputDto);
        Task Delete(int id);
        Task Update(CommentInputDto commentInputDto);
        ValueTask<CommentOutputDto> Get(int id);
        Task<List<CommentOutputDto>> GetAll();
    }
}
