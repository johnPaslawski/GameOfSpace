using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfSpace.Domain.Models
{
    public class CentralStar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SunMass { get; set; }
        public int Temperature { get; set; }
        public PlanetarySystem PlanetarySystem { get; set; }
    }
}
