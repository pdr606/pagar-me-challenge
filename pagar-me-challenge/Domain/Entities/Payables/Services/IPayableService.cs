using pagar_me_challenge.Domains.Entities.Transaction.Enum;

namespace pagar_me_challenge.Domain.Entities.PayablesEntity.Services
{
    public interface IPayableService
    {
        (Payable, decimal totalWithFee) Add(decimal total, PaymentMethod paymentMethod);
    }
}
