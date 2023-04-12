namespace Demo.Models
{
    public class CreditCard : IAccount
    {
        public string AccessNumber { get; set; } = null!;
        public string CardNumber { get; set; } = null!;
        public string ControlAccountNumber { get; set; } = null!;

        public string PrimaryAccountHolder { get; set; } = null!;

        public string SecondaryAccountHolder { get; set; } = null!;

        public decimal CreditLimit { get; set; }

        public decimal InterestRate { get; set; }
    }
}
