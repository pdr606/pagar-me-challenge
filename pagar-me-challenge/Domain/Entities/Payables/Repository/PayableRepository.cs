using pagar_me_challenge.Db.Config;
using pagar_me_challenge.Domains.Base.Repository;

namespace pagar_me_challenge.Domain.Entities.PayablesEntity.Repository
{
    public class PayableRepository : BaseRepository<Payable> , IPayableRepository
    {
        public PayableRepository(AppDbContext db) : base(db)
        {
        }
    }
}
