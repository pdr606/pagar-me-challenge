using pagar_me_challenge.Domains.Entities.TransactionEntity;
using System.Transactions;

namespace pagar_me_challenge.Domains.Entities.TransactionEntity.Services
{
    public interface ITransactionService
    {
        Task<List<Transaction>> Add(Transaction entity);
        Task<(decimal paid, decimal wating)> FindStats();
    };
}
