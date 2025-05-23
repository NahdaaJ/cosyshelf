using CosyShelf.Data.Entities;
using SQLite;

namespace CosyShelf.Data.Database
{
    public class DatabaseInitialiser
    {
        private readonly string _dbPath;
        public DatabaseInitialiser(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task InitialiseDatabaseAsync()
        {
            var db = new SQLiteAsyncConnection(_dbPath);

            await db.CreateTableAsync<BookEntity>();
            await db.CreateTableAsync<ReadingSessionEntity>();
        }
    }
}
