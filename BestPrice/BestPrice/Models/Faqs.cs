using System;
using System.Collections.Generic;

namespace BestPrice.Models
{
    public partial class Faqs
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
