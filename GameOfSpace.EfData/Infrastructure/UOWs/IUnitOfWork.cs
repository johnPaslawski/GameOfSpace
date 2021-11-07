using GameOfSpace.Domain.Models;
using GameOfSpace.EFCore.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfSpace.EFCore.Infrastructure.UOWs
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Building> Buildings { get; }
        IGenericRepository<BuildingType> BuildingTypes { get; }
        IGenericRepository<CentralStar> CentralStars { get; }
        IGenericRepository<Planet> Planets { get; }
        IGenericRepository<PlanetarySystem> PlanetarySystems { get; }
        IGenericRepository<User> Users { get; }
        IGenericRepository<Stats> Stats { get; }
        IGenericRepository<Resources> Resources { get; }
        IGenericRepository<Galaxy> Galaxies { get; }
        Task Save();
        void SaveSync();
        void PopulateDb();

    }
}
