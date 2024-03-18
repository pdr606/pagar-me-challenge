using pagar_me_challenge.Application.TransactionEntity.Dto;
using pagar_me_challenge.Application.TransactionEntity.Adapter;
using pagar_me_challenge.Domains.Entities.TransactionEntity.Services;

namespace pagar_me_challenge.Application.TransactionEntity.Services
{
    public class TransactionApplicationService : ITransactionApplicationService
    {
        private readonly ITransactionService _transactionService;

        public TransactionApplicationService(ITransactionService transactionService){

            _transactionService = transactionService;
        }

        public async Task<IEnumerable<TransactionResponseDto>> Add(TransactionRequestDto dto)
        {
            var entities = await _transactionService.Add(TransactionAdapter.ToEntity(dto));
            
            return TransactionAdapter.ToDtoList(entities);
        }

        public async Task<TransactionStatsResponseDto> Stats()
        {
            var stat = await _transactionService.FindStats();

            return TransactionAdapter.ToDto(stat.paid, stat.wating);
        }
    }
}
