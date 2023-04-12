namespace Demo.Models
{
    public class CommonAccount : IAccount
    {
        public string AccessNumber { get; set; } = null!;
        public string AccountNumber { get; set; } = null!;

        public string Name { get; set; } = null!;
        public decimal AvailableBalance { get; set; }
        public decimal Balance { get; set; }
    }
}
