using System.Data.Entity.Migrations;
using System.Linq;
using PlanetDatabase.Common.Entities;

namespace PlanetDatabase.Data
{
    public sealed class PlanetDatabaseConfiguration : DbMigrationsConfiguration<PlanetDatabaseDbContext>
    {
        public PlanetDatabaseConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PlanetDatabaseDbContext context)
        {
            AddIfNotExists(context, new Planet { Id = 1, Name = "Mercury", DistanceToSolar = GetKilometers(.387F) });
            AddIfNotExists(context, new Planet { Id = 2, Name = "Venus", DistanceToSolar = GetKilometers(.722F) });
            AddIfNotExists(context, new Planet { Id = 3, Name = "Earth", DistanceToSolar = GetKilometers(1F) });
            AddIfNotExists(context, new Planet { Id = 4, Name = "Mars", DistanceToSolar = GetKilometers(1.52F) });

            AddIfNotExists(context, new Planet { Id = 5, Name = "Jupiter", DistanceToSolar = GetKilometers(5.2F) });
            AddIfNotExists(context, new Planet { Id = 6, Name = "Saturn", DistanceToSolar = GetKilometers(9.58F) });
            AddIfNotExists(context, new Planet { Id = 7, Name = "Uranus", DistanceToSolar = GetKilometers(19.2F) });
            AddIfNotExists(context, new Planet { Id = 8, Name = "Neptune", DistanceToSolar = GetKilometers(30.1F) });

            context.SaveChanges();
        }

        private long GetKilometers(float au)
        {
            const long kilometersInAu = 149598000;
            return (long)(au * kilometersInAu);
        }

        private static void AddIfNotExists(PlanetDatabaseDbContext context, Planet planet)
        {
            if (context.Planets.Any(c => c.Id == planet.Id) == false)
            {
                context.Planets.Add(planet);
            }
        }
    }
}