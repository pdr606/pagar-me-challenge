using pagar_me_challenge.Domains.Base.Repository;
using pagar_me_challenge.Domains.Entities.TransactionEntity;

namespace pagar_me_challenge.Domains.Entities.TransactionEntity.Repository
{
    public interface ITransactionRepository : IBaseRepository<Transaction>
    {
        Task<List<Transaction>> FindAllWithNoTrackingInclude();
    }
}
