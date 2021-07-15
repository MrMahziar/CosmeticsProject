using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Input;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService CommentService;

        public CommentController(ICommentService CommentService)
        {
            this.CommentService = CommentService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CommentInputDto commentInputDto)
        {
            await CommentService.Insert(commentInputDto);
            return Ok();

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var comment = await CommentService.Get(id);
            return Ok(comment);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var comment = await CommentService.GetAll();
            return Ok(comment);
        }
        [HttpPut]

        public async Task<IActionResult> Update(CommentInputDto commentInputDto)
        {
            await CommentService.Update(commentInputDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await CommentService.Delete(id);
            return Ok();
        }
    }
}