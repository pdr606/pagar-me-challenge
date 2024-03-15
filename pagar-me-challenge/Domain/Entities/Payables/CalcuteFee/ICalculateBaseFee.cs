namespace pagar_me_challenge.Domain.Entities.Payables.CalcuteFee
{
    public interface ICalculateBaseFee
    {
        decimal Calculate(decimal total);
    }
}
