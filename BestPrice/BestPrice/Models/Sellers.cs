using System;
using System.Collections.Generic;

namespace BestPrice.Models
{
    public partial class Sellers
    {
        public Sellers()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
