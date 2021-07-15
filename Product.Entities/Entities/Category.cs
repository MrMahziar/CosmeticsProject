using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Entities
{
    public  class Category
    { 
        public int Id { get; set; }
        public string CategoryName { get; set; }
        //public int ProductId { get; set; }
        public List<Product>  Products { get; set; }
    }
}
