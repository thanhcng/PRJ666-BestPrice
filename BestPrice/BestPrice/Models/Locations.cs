using System;
using System.Collections.Generic;

namespace BestPrice.Models
{
    public partial class Locations
    {
        public Locations()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
