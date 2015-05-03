using System.Collections.Generic;
using PlanetDatabase.Common.Entities;

namespace PlanetDatabase.Common
{
    public interface IPlanetsRepository
    {
        IEnumerable<Planet> GetAllPlanets();
        Planet GetById(int id);
    }
}
