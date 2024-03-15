using Microsoft.EntityFrameworkCore;
using pagar_me_challenge.Db.Config;
using pagar_me_challenge.Domains.Base.Repository;
using pagar_me_challenge.Domains.Entities.TransactionEntity;

namespace pagar_me_challenge.Domains.Entities.TransactionEntity.Repository
{
    public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(AppDbContext db) : base(db)
        {
        }

        public Task<List<Transaction>> FindAllWithNoTrackingInclude()
        {
            return _db.Set<Transaction>().Include(x => x.Payable).AsNoTracking().ToListAsync();
        }
    }
}
