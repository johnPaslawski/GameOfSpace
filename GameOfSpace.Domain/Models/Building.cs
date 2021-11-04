using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfSpace.Domain.Models
{
    public class Building
    {
        public int Id { get; set; }
        public bool UnderConstruction { get; set; }
        public BuildingType BuildingType { get; set; }
        public int BuildingTypeId { get; set; }
        public DateTime TimeOfBuilt { get; set; }
        public Planet Planet { get; set; }
    }
}
