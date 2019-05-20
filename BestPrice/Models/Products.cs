using System;
using System.Collections.Generic;

namespace BestPrice.Models
{
    public partial class Products
    {
        public Products()
        {
            Notifications = new HashSet<Notifications>();
            Reviews = new HashSet<Reviews>();
            WishlistProduct = new HashSet<WishlistProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal BeforePrice { get; set; }
        public int SellerId { get; set; }

        public virtual Sellers Seller { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
        public virtual ICollection<WishlistProduct> WishlistProduct { get; set; }
    }
}
