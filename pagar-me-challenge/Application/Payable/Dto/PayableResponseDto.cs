using pagar_me_challenge.Domain.Entities.Payables.ValueObjects;

namespace pagar_me_challenge.Application.PayableEntity.Dto
{
    public record PayableResponseDto(string paymenteDate,
                                     string status,
                                     int fee
                                     );
}
