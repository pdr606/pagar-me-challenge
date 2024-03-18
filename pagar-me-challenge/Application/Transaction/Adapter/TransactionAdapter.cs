using pagar_me_challenge.Application.PayableEntity.Adapter;
using pagar_me_challenge.Application.TransactionEntity.Dto;
using pagar_me_challenge.Domains.Entities.TransactionEntity;

namespace pagar_me_challenge.Application.TransactionEntity.Adapter
{
    public static class TransactionAdapter
    {

        public static Transaction ToEntity(TransactionRequestDto dto)
        {
            decimal.TryParse(dto.total, out var totalTransaction);

            return new Transaction(dto.card,
                                   dto.paymentMethod,
                                   dto.description,
                                   totalTransaction
                                   );
        }

        public static TransactionResponseDto ToDto(Transaction entity)
        {
            return new TransactionResponseDto(entity.Total.ToString(),
                                              entity.Description,
                                              entity.Card,
                                              entity.PaymentMethod,
                                              PayableAdapter.toDto(entity.Payable)
                                              );
        }

        public static IEnumerable<TransactionResponseDto> ToDtoList(List<Transaction> entities)
        {
            for(int i = 0; i < entities.Count; i++)
            {
                yield return ToDto(entities[i]);
            }
        }
        public static TransactionStatsResponseDto ToDto(decimal availableFunds, decimal waitingFunds)
        {
            return new TransactionStatsResponseDto(availableFunds.ToString("N2"), waitingFunds.ToString("N2"));
        }
    }
}
