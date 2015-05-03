using System.Data.Entity;
using PlanetDatabase.Common.Entities;

namespace PlanetDatabase.Data
{
    public class PlanetDatabaseDbContext : DbContext
    {
        static PlanetDatabaseDbContext() { Database.SetInitializer(new PlanetDatabaseInitializer()); }
        public PlanetDatabaseDbContext() : base("name=Default") { }

        public IDbSet<Planet> Planets { get; set; }
    }
}