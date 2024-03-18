using pagar_me_challenge.Domain.Entities.Payables.ValueObjects;
using pagar_me_challenge.Domain.Entities.PayablesEntity;
using pagar_me_challenge.Domains.Entities.Transaction.Enum;
using pagar_me_challenge.Domains.Entities.Transaction.ValueObjects;

namespace pagar_me_challenge.Domains.Entities.TransactionEntity
{
    public class Transaction
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public decimal Total { get;  set; }
        public string Description { get; private set; } = string.Empty;
        public Card Card { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public Payable Payable { get;  set; }
        public Guid PayableId{ get; set; }

        public Transaction() { }

        public Transaction(Card card, PaymentMethod paymentMethod, string description, decimal total)
        {
            Card = card;
            PaymentMethod = paymentMethod;
            Description = description;
            Total = total;
        }

        public Transaction BindingPayable(Payable payable)
        {
            Payable = payable;
            return this;
        }

        public void AtualizateTotalWithFee(decimal total)
        {
            Total = total;
        }
    }
}
