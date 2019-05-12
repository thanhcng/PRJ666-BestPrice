using System;
using System.Collections.Generic;

namespace BestPrice.Models
{
    public partial class Reviews
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public int ProductId { get; set; }

        public virtual Products Product { get; set; }
    }
}
