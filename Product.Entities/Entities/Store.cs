using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string Email { get; set; }
        public string Tell { get; set; }
        public List<StoreProduct> StoreProducts { get; set; }

    }
}
