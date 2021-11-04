using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfSpace.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public Stats Stats { get; set; }
        public List<PlanetarySystem> PlanetarySystems { get; set; } = new List<PlanetarySystem>();
    }
}
