using System.Collections.Generic;
using System.Linq;
using PlanetDatabase.Common;
using PlanetDatabase.Common.Entities;

namespace PlanetDatabase.Data
{
    public class PlanetsRepository : IPlanetsRepository
    {
        private readonly PlanetDatabaseDbContext _dbContext;

        public PlanetsRepository(PlanetDatabaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Planet> GetAllPlanets()
        {
            return _dbContext.Planets.ToArray();
        }

        public Planet GetById(int id)
        {
            return _dbContext.Planets.FirstOrDefault(p => p.Id == id);
        }
    }
}