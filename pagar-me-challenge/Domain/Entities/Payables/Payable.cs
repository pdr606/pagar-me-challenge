using pagar_me_challenge.Domain.Entities.Payables.ValueObjects;
using pagar_me_challenge.Domains.Entities.TransactionEntity;

namespace pagar_me_challenge.Domain.Entities.PayablesEntity
{
    public class Payable
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public DateTime PaymenteDate{ get; private set; } = DateTime.Now.AddDays(30);
        public Status Status { get; set; }
        public int Fee{ get; private set; }
        public Transaction Transaction{ get; private set; }

        public Payable() { }

        public Payable(Status status, int fee)
        {
            Status = status;
            Fee = fee;
        }
    }
}
