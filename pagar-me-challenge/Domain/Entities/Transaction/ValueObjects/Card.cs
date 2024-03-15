namespace pagar_me_challenge.Domains.Entities.Transaction.ValueObjects
{
    public sealed class Card
    {
        public string Number { get; private set; } = string.Empty;
        public string Carrier { get; private set; } = string.Empty;
        public string Validate { get; private set; } = string.Empty;
        public int CVV { get; private set; }

        public Card(string number, string carrier, string validate, int cVV)
        {
            Number = MaskCardNumber(number);
            Carrier = carrier;
            Validate = validate;
            CVV = cVV;
        }

        private string MaskCardNumber(string cardNumber)
        {
            return cardNumber.Substring(cardNumber.Length - 4);
        }
    }
}
