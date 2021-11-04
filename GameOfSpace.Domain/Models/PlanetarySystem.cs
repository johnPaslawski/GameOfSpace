using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfSpace.Domain.Models
{
    public class PlanetarySystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public CentralStar CentralStar { get; set; }
        public int CentralStarId { get; set; }
        public List<Planet> Planets { get; set; } = new List<Planet>();


    }
}
