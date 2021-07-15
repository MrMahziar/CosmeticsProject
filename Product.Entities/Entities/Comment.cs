using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cosmetics.Entities
{
 
    [Table("Comment")]
    public  class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public User User { get; set; }
        public Product  Product { get; set; }
        public DateTime RegisterDate { get; set; }
        public String CommentText { get; set; }
    }
}
