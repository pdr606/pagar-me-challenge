using pagar_me_challenge.Application.PayableEntity.Dto;
using pagar_me_challenge.Domain.Entities.PayablesEntity;

namespace pagar_me_challenge.Application.PayableEntity.Adapter
{
    public static class PayableAdapter
    {

        public static PayableResponseDto toDto(Payable entity)
        {
            return new PayableResponseDto(entity.PaymenteDate.ToString("dd/MM/yyyy HH:mm:ss"),
                                          entity.Status.ToString(),
                                          entity.Fee);
        }
    }
}
