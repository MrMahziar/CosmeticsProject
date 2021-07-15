using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Application.Services.Dto.Output
{
   public class ProductOutputDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Comment { get; set; }
        public string Country { get; set; }
        public double Weight { get; set; }
    }
}
