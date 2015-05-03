using System.Data.Entity;

namespace PlanetDatabase.Data
{
    public class PlanetDatabaseInitializer :
        MigrateDatabaseToLatestVersion<PlanetDatabaseDbContext, PlanetDatabaseConfiguration>
    {
    }
}