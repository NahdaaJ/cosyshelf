using SQLite;

namespace CosyShelf.Data.Repositories
{
    public class SQLiteRepository<T> : IRepository<T> where T : new()
    {
        private readonly SQLiteAsyncConnection _db;
        public SQLiteRepository(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
        }

        public Task AddAsync(T entity) => _db.InsertAsync(entity);

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                await _db.DeleteAsync(entity);
            }
        }

        public Task UpdateAsync(T entity) => _db.UpdateAsync(entity);

        public Task<List<T>> GetAllAsync() => _db.Table<T>().ToListAsync();

        public Task<T?> GetByIdAsync(int id) => _db.FindAsync<T>(id);

    }
}
