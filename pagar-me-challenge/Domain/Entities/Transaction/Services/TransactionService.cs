using pagar_me_challenge.Domain.Entities.PayablesEntity.Services;
using pagar_me_challenge.Domains.Entities.TransactionEntity.Repository;
using pagar_me_challenge.Domains.Entities.TransactionEntity.Services;

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
    }
}
