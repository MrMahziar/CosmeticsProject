using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.EF.Persistance.CosmeticsDatabase;
using Cosmetics.Entities;
using Cosmetics.Entities.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Cosmetics.EF.Persistance.Repository
{
    public class CommentRepository : IRepositoryComment
    {
        private readonly AppDBContext dBContext;

        public CommentRepository(AppDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public async Task DeleteAsync(int id)
        {
            var userComment = await dBContext.UserComments.FindAsync(id);
            if (userComment == null)
            {
                throw new FileNotFoundException();
            }
            dBContext.UserComments.Remove(userComment);
        }

        public Task<List<Comment>> GetAllCommentAsync()
        {
            return dBContext.UserComments.ToListAsync();
        }

        public async ValueTask<Comment> GetAsync(int id)
        {
            var userComment = await dBContext.UserComments.FindAsync(id);
            if (userComment == null)
            {
                throw new FileNotFoundException();
            }
            return userComment;
        }

        public IQueryable GetQueryable()
        {

            return dBContext.UserComments.AsQueryable();
        }

        public void Insert(Comment comment)
        {
            dBContext.UserComments.Add(comment);
        }

        public async Task UpdateAsync(Comment comment)
        {
            var resultComment = await dBContext.UserComments.FindAsync(comment.Id);
            if (resultComment == null)
            {
                throw new KeyNotFoundException();
            }
            dBContext.Update(resultComment);
        }
    }
}
