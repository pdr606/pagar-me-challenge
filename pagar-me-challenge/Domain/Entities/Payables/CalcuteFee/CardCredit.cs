namespace pagar_me_challenge.Domain.Entities.Payables.CalcuteFee
{
    public class CardCredit : ICalculateBaseFee
    {
        public decimal Calculate(decimal total)
        {
            return total - ((total * 5) / 100);
        }
    }
}
