using pagar_me_challenge.Domain.Entities.Payables.ValueObjects;
using pagar_me_challenge.Domain.Entities.PayablesEntity.Services;
using pagar_me_challenge.Domains.Entities.TransactionEntity.Repository;

namespace pagar_me_challenge.Domains.Entities.TransactionEntity.Services
{
    public class TransactionService : ITransactionService
    {

        private readonly ITransactionRepository _transactionRepository;
        private readonly IPayableService _payableService;

        public TransactionService(ITransactionRepository transactionRepository, IPayableService payableService)
        {
            _transactionRepository = transactionRepository;
            _payableService = payableService;
        }
        
        public async Task<List<Transaction>> Add(Transaction entity)
        {
            (var payable, var totalWithFee) = _payableService.Add(entity.Total, entity.PaymentMethod);

            entity.BindingPayable(payable);
            entity.AtualizateTotalWithFee(totalWithFee);

            await _transactionRepository.Add(entity);

            return await _transactionRepository.FindAllWithNoTrackingInclude();
        }

        public async Task<(decimal paid, decimal wating)> FindStats()
        {
            var entities = await _transactionRepository.FindAllStatsWithNoTracking();

            return CalculateStats(entities);
        }

        private (decimal paid, decimal wating) CalculateStats(List<Transaction> entities) 
        {
            var paid = 0M;
            var wating = 0M;

            foreach(var transaction in entities)
            {
                if(transaction.Payable.Status == Status.paid)
                    paid += transaction.Total;
                else
                    wating += transaction.Total;
            }

            return (paid, wating);
        }

    }
}
