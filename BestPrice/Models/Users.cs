using System;
using System.Collections.Generic;

namespace BestPrice.Models
{
    public partial class Users
    {
        public Users()
        {
            Notifications = new HashSet<Notifications>();
            SearchHistories = new HashSet<SearchHistories>();
            Wishlists = new HashSet<Wishlists>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? LocationId { get; set; }

        public virtual Locations Location { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
        public virtual ICollection<SearchHistories> SearchHistories { get; set; }
        public virtual ICollection<Wishlists> Wishlists { get; set; }
    }
}
