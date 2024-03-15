using Microsoft.EntityFrameworkCore;
using pagar_me_challenge.Db.Config;

namespace pagar_me_challenge.Domains.Base.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        protected readonly AppDbContext _db;

        public BaseRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task Add(TEntity entity)
        {
            await _db.Set<TEntity>().AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<List<TEntity>> FindAllNoTracking()
        {
            return await _db.Set<TEntity>().AsNoTracking().ToListAsync();
        }
    }
}
