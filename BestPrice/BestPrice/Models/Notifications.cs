using System;
using System.Collections.Generic;

namespace BestPrice.Models
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }

        public virtual Products Product { get; set; }
        public virtual Users User { get; set; }
    }
}
