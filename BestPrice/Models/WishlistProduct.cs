using System;
using System.Collections.Generic;

namespace BestPrice.Models
{
    public partial class WishlistProduct
    {
        public int WishlistId { get; set; }
        public int ProductId { get; set; }

        public virtual Products Product { get; set; }
        public virtual Wishlists Wishlist { get; set; }
    }
}
