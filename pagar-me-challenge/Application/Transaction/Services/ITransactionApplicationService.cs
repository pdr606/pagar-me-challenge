using pagar_me_challenge.Application.TransactionEntity.Dto;

namespace pagar_me_challenge.Application.TransactionEntity.Services
{
    public interface ITransactionApplicationService
    {
        Task<IEnumerable<TransactionResponseDto>> Add(TransactionRequestDto dto);
    }
}
