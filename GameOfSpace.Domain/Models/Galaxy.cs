using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfSpace.Domain.Models
{
    public class Galaxy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Diameter { get; set; }
        public List<PlanetarySystem> PlanetarySystems { get; set; } = new List<PlanetarySystem>();
    }
}
