using GameOfSpace.Domain.Models;
using GameOfSpace.EFCore.Infrastructure.UOWs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameOfSpace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class APITestMethodsController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public APITestMethodsController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        /// <summary>
        /// THIS METHOD RETURNS PLANETARY SYSTEM ON GIVEN ID
        /// </summary>
        [HttpGet("getUser/{id}")]
        public async Task<User> GetUserIncludePlanetarySystem(int id)
        {
            var planetarySystem = await _uow.Users.Get(x => x.Id == id, new List<string>() { "PlanetarySystems.Planets", "PlanetarySystems.CentralStar", "Stats" });
            if (planetarySystem == null)
            {
                //return NotFound($"planetarySystem with id = {id} was not found.");
            }
            return planetarySystem;
        }

        [HttpPost("attachPlanetSystemToUser/{planetSysId}/{userId}")]
        public async Task<ActionResult> AttachPlanetarySystemToUser(int planetSysId, int userId)
        {
            //DOPISANIE UKŁADU SŁONECZNEGO DO USERA
            //(można byłoby również poprzez stworzenie nowego, zamiast nadpisywania Id, przy dodawaniu statów to zadziałało)
            var planetarySystem = await _uow.PlanetarySystems.Get(x => x.Id == planetSysId);
            planetarySystem.UserId = userId;
            _uow.PlanetarySystems.Modify(planetarySystem);
            await _uow.Save();

            return Ok();
        }

        [HttpGet("getPlanetarySystem/{id}")]
        public async Task<PlanetarySystem> GetPlanetarySystemIncludePlanets(int id)
        {
            return await _uow.PlanetarySystems.Get(x => x.Id == id, new List<string>() { "Planets" });

        }

        [HttpPost("modifyUserStats/{statsId}")]
        public async Task<ActionResult> CurrentBackendAction(int statsId)
        {
            //DODAWANIE NOWYCH STATÓW
            //var user = await _uow.Users.Get(x => x.Id == id);
            //user.Stats = new Stats { Exp = 2, Level = -69 };
            //_uow.Users.Modify(user);
            //await _uow.Save();

            //EDYTOWANIE ISTNIEJĄCYCH STATÓW (mozna chyba tylko porzez staty, czyli potrzebujemy Id tych statów które chcemy modyfikować.
            //nie bardzo da sie prze usera)
            //(może dlatego że stats. level lub exp jet już poziom głębiej niż samo user.stats ?)
            //var stats = await _uow.Stats.Get(x => x.Id == statsId);
            //stats.Level = 420;
            //_uow.Stats.Modify(stats);
            //await _uow.Save();

            return Ok();

        }

        [HttpGet("populateDb/")]
         public void PopulateDB()
        {
            _uow.PopulateDb();
        }

        //[HttpGet]
        //public async Task<IActionResult> PopulateDb()
        //{
        //    //var user = new User { UserName = "janekDzbanek" };
        //    //await _uow.Users.Add(user);
        //    //await _uow.Save();
        //    //var user2 = new User { UserName = "kosgameKondek" };
        //    //await _uow.Users.Add(user2);
        //    //await _uow.Save();

        //    //var planetarySystem = new PlanetarySystem { Name = "Alfa Menkalinan" };
        //    //var planetarySystem2 = new PlanetarySystem { Name = "Gamma Cygnus" };
        //    //var planetarySystem3 = new PlanetarySystem { Name = "Alfa Andromedae" };
        //    //var PSList = new List<PlanetarySystem>() { planetarySystem, planetarySystem2, planetarySystem3 };
        //    //await _uow.PlanetarySystems.AddRange(PSList);
        //    //await _uow.Save();

        //    //var planet = new Planet { Name = "Acamar", MinTemp = -90, MaxTemp = 78 };
        //    //var planet2 = new Planet { Name = "Anadolu", MinTemp = -20, MaxTemp = 122 };
        //    //var planet3 = new Planet { Name = "Baekdu", MinTemp = 50, MaxTemp = 189 };
        //    //var planet4 = new Planet { Name = "Chaophraya", MinTemp = 33, MaxTemp = 130 };
        //    //var planet5 = new Planet { Name = "Gakyid", MinTemp = 86, MaxTemp = 98 };
        //    //var planet6 = new Planet { Name = "Mazaalai", MinTemp = -122, MaxTemp = -31 };
        //    //var planet7 = new Planet { Name = "Mirphak", MinTemp = -19, MaxTemp = 88 };
        //    //var planet8 = new Planet { Name = "Sheratan", MinTemp = -63, MaxTemp = 10 };
        //    //var planet9 = new Planet { Name = "Centauri A", MinTemp = -189, MaxTemp = -20 };
        //    //var planet10 = new Planet { Name = "Nenque", MinTemp = -2, MaxTemp = 46 };
        //    //var PList = new List<Planet> { planet, planet2, planet3, planet4, planet5, planet6, planet7, planet8, planet9, planet10 };
        //    //await _uow.Planets.AddRange(PList);
        //    //await _uow.Save();

        //    //var cStar1 = new CentralStar { Name = "π Sagittarii", SunMass = 17, Temperature = 5000 };
        //    //var cStar2= new CentralStar { Name = "α Cephei", SunMass = 84, Temperature = 10000 };
        //    //var cStar3 = new CentralStar { Name = "ζ Draconis", SunMass = 2, Temperature = 3200 };
        //    //var CSList = new List<CentralStar> { cStar1, cStar2, cStar3 };
        //    //await _uow.CentralStars.AddRange(CSList);
        //    //await _uow.Save();

        //    //var ps = await _uow.PlanetarySystems.Get(x => x.Id == 1);
        //    //_uow.Users.Get(x => x.Id == 2, new List<string> { "PlanetarySystems" }).Result.PlanetarySystems.Add(ps) ;
        //    //await _uow.Save();

        //    return Ok();
        //}
    }
}
