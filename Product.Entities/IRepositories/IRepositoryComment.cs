using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Entities.IRepositories
{
    public interface IRepositoryComment
    {
        void Insert(Comment comment);
        Task UpdateAsync(Comment comment);
        Task DeleteAsync(int id);
        ValueTask<Comment> GetAsync(int id);
        Task<List<Comment>> GetAllCommentAsync();
        IQueryable GetQueryable();
    }
}
