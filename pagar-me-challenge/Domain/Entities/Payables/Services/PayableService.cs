using pagar_me_challenge.Domain.Entities.Payables.CalcuteFee;
using pagar_me_challenge.Domain.Entities.Payables.ValueObjects;
using pagar_me_challenge.Domain.Entities.PayablesEntity;
using pagar_me_challenge.Domain.Entities.PayablesEntity.Repository;
using pagar_me_challenge.Domain.Entities.PayablesEntity.Services;
using pagar_me_challenge.Domains.Entities.Transaction.Enum;

namespace pagar_me_challenge.Domain.Entities.Payables.Services
{
    public class PayableService : IPayableService
    {
        private readonly IPayableRepository _payableRepository;

        public PayableService(IPayableRepository payableRepository)
        {
            _payableRepository = payableRepository;
        }

        public (Payable, decimal totalWithFee) Add(decimal total, PaymentMethod paymentMethod)
        {
            (int fee, Status status) = SetPayableValues(paymentMethod);

            return (new Payable(status, fee), CalculateTotalFee(total, paymentMethod));
        }

        private (int fee, Status status) SetPayableValues(PaymentMethod paymentMethod)
        {
            return paymentMethod == PaymentMethod.debit_card ? (3, Status.paid) : (3, Status.waiting_funds);
        }

        private decimal CalculateTotalFee(decimal total, PaymentMethod paymentMethod)
        {
            if(paymentMethod == PaymentMethod.credit_car)
            {
                var credit = new CardCredit();
                return credit.Calculate(total);
            }

            var debit = new CardDebit();
            return debit.Calculate(total);
        }
    }
}
