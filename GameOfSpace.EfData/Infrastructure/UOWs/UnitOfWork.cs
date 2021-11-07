using GameOfSpace.Domain.Models;
using GameOfSpace.EFCore.EFData;
using GameOfSpace.EFCore.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfSpace.EFCore.Infrastructure.UOWs
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameOfSpaceDbContext _context;
        public UnitOfWork(GameOfSpaceDbContext context)
        {
            this._context = context;
        }
        public IGenericRepository<Building> Buildings => new GenericRepository<Building>(_context);
        public IGenericRepository<BuildingType> BuildingTypes => new GenericRepository<BuildingType>(_context);
        public IGenericRepository<CentralStar> CentralStars => new GenericRepository<CentralStar>(_context);
        public IGenericRepository<Planet> Planets => new GenericRepository<Planet>(_context);
        public IGenericRepository<PlanetarySystem> PlanetarySystems => new GenericRepository<PlanetarySystem>(_context);
        public IGenericRepository<User> Users => new GenericRepository<User>(_context);
        public IGenericRepository<Stats> Stats => new GenericRepository<Stats>(_context);
        public IGenericRepository<Resources> Resources => new GenericRepository<Resources>(_context);
        public IGenericRepository<Galaxy> Galaxies => new GenericRepository<Galaxy>(_context);

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void SaveSync()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(true);
        }

        public void PopulateDb()
        {
            //var planetarySystem = new PlanetarySystem { Name = "Alfa Menkalinan" };
            //var planetarySystem2 = new PlanetarySystem { Name = "Gamma Cygnus" };
            //var planetarySystem3 = new PlanetarySystem { Name = "Alfa Andromedae" };
            //var PSList = new List<PlanetarySystem>() { planetarySystem, planetarySystem2, planetarySystem3 };

            //var planet = new Planet { Name = "Acamar", MinTemp = -90, MaxTemp = 78 };
            //var planet2 = new Planet { Name = "Anadolu", MinTemp = -20, MaxTemp = 122 };
            //var planet3 = new Planet { Name = "Baekdu", MinTemp = 50, MaxTemp = 189 };
            //var planet4 = new Planet { Name = "Chaophraya", MinTemp = 33, MaxTemp = 130 };
            //var planet5 = new Planet { Name = "Gakyid", MinTemp = 86, MaxTemp = 98 };
            //var planet6 = new Planet { Name = "Mazaalai", MinTemp = -122, MaxTemp = -31 };
            //var planet7 = new Planet { Name = "Mirphak", MinTemp = -19, MaxTemp = 88 };
            //var planet8 = new Planet { Name = "Sheratan", MinTemp = -63, MaxTemp = 10 };
            //var planet9 = new Planet { Name = "Centauri A", MinTemp = -189, MaxTemp = -20 };
            //var planet10 = new Planet { Name = "Nenque", MinTemp = -2, MaxTemp = 46 };
            //var PList = new List<Planet> { planet, planet2, planet3, planet4, planet5, planet6, planet7, planet8, planet9, planet10 };


            //var cStar1 = new CentralStar { Name = "π Sagittarii", SunMass = 17, Temperature = 5000 };
            //var cStar2 = new CentralStar { Name = "α Cephei", SunMass = 84, Temperature = 10000 };
            //var cStar3 = new CentralStar { Name = "ζ Draconis", SunMass = 2, Temperature = 3200 };

            //_context.AddRange(
            //      new User { UserName = "nowyJanekDzbanek" },
            //      new User { UserName = "nowyKosgameKondek" }
            //);

            //_context.AddRange(
            //      new CentralStar { Name = "π Sagittarii", SunMass = 17, Temperature = 5000 },
            //      new CentralStar { Name = "α Cephei", SunMass = 84, Temperature = 10000 }
            //);

            //_context.AddRange(
            //    new PlanetarySystem { Name = "Andromedae B 3546", UserId = 1, CentralStarId = 1 },
            //    new PlanetarySystem { Name = "Sigma Altair U188E", UserId = 2, CentralStarId = 2 }
            //);

            //_context.AddRange(
            //    new Planet { Name = "Acamar", MinTemp = -90, MaxTemp = 78, PlanetarySystemId = 4 },
            //    new Planet { Name = "Anadolu", MinTemp = -20, MaxTemp = 122, PlanetarySystemId = 5 },
            //    new Planet { Name = "Chaophraya", MinTemp = 33, MaxTemp = 130, PlanetarySystemId = 4 },
            //    new Planet { Name = "Baekdu", MinTemp = 50, MaxTemp = 189, PlanetarySystemId = 4 },
            //    new Planet { Name = "Gakyid", MinTemp = 86, MaxTemp = 98, PlanetarySystemId = 4 },
            //    new Planet { Name = "Mazaalai", MinTemp = -122, MaxTemp = -31, PlanetarySystemId = 5 },
            //    new Planet { Name = "Mirphak", MinTemp = -19, MaxTemp = 88, PlanetarySystemId = 4 },
            //    new Planet { Name = "Sheratan", MinTemp = -63, MaxTemp = 10, PlanetarySystemId = 4 },
            //    new Planet { Name = "Centauri A", MinTemp = -189, MaxTemp = -20, PlanetarySystemId = 5 },
            //    new Planet { Name = "Nenque", MinTemp = -2, MaxTemp = 46, PlanetarySystemId = 5 },
            //    new Planet { Name = "Acabyymar", MinTemp = -95, MaxTemp = 44, PlanetarySystemId = 4 },
            //    new Planet { Name = "Lernadolu", MinTemp = -30, MaxTemp = 103, PlanetarySystemId = 5 },
            //    new Planet { Name = "Chaya", MinTemp = 36, MaxTemp = 170, PlanetarySystemId = 4 },
            //    new Planet { Name = "Yeeaekdu", MinTemp = 45, MaxTemp = 189, PlanetarySystemId = 4 }
            //);

            //_context.SaveChanges();

        }
    }
}
