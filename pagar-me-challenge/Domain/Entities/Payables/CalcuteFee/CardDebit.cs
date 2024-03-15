namespace pagar_me_challenge.Domain.Entities.Payables.CalcuteFee
{
    public class CardDebit : ICalculateBaseFee
    {
        public decimal Calculate(decimal total)
        {
            return total - ((total * 3) / 100);
        }
    }
}
