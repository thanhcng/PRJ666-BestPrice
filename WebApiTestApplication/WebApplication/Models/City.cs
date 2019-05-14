using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Coordinate Coord { get; set; }
        public string country { get; set; }
    }
}
