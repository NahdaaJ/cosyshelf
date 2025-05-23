using CosyShelf.Data.Database;

namespace CosyShelf.UI
{
    public static class AppSetup
    {
        public static async Task InitialiseDb()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "cosyshelf.db");
            var db = new DatabaseInitialiser(dbPath);
            await db.InitialiseDatabaseAsync();
        }
    }
}
