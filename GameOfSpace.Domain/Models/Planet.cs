using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfSpace.Domain.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public string Population { get; set; }
        public int PlanetarySystemId { get; set; }
        public PlanetarySystem PlanetarySystem { get; set; }
        public string ImagePath { get; set; }
        public List<Resources> AvailableResources { get; set; } = new List<Resources>();
        public List<Building> Buildings { get; set; } = new List<Building>();

    }
}
