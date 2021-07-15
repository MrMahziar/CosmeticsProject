using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Entities
{
   public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public List<Comment> UserComments { get; set; }

    }
    public enum UserType
    {
        Administrator,
        StoreManager,
        User
    }
}
