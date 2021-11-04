using GameOfSpace.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfSpace.EFCore.EFData
{
    public class GameOfSpaceDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PlanetarySystem> PlanetarySystems { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<CentralStar> CentralStars { get; set; }
        public DbSet<BuildingType> BuildingTypes { get; set; }
        public DbSet<Building> Buildings { get; set; }

        public GameOfSpaceDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
