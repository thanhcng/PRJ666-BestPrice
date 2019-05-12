using System;
using System.Collections.Generic;

namespace BestPrice.Models
{
    public partial class Wishlists
    {
        public Wishlists()
        {
            WishlistProduct = new HashSet<WishlistProduct>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<WishlistProduct> WishlistProduct { get; set; }
    }
}
