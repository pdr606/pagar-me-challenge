using pagar_me_challenge.Application.PayableEntity.Dto;
using pagar_me_challenge.Domains.Entities.Transaction.Enum;
using pagar_me_challenge.Domains.Entities.Transaction.ValueObjects;

namespace pagar_me_challenge.Application.TransactionEntity.Dto
{
    public record TransactionResponseDto(string total,
                                         string description,
                                         Card card,
                                         PaymentMethod PaymentMethod,
                                         PayableResponseDto payable
                                         )
    {
    }
}
