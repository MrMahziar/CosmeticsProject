using System;
using System.Collections.Generic;
using System.Text;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Dto.Output
{
    public  class UserOutputDto
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
