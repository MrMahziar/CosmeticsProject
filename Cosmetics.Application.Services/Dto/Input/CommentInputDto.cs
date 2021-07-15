using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Application.Services.Dto.Input
{
    public class CommentInputDto
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public String CommentText { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
