using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfSpace.Domain.Models
{
    public class Resources
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Quantity { get; set; }
        public int? PlanetId { get; set; }
        public int? UserId { get; set; }
    }
}
