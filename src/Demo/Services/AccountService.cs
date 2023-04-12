using Demo.Models;

namespace Demo.Services
{
    public class AccountService : IAccountService
    {
        public Task<List<CommonAccount>> GetCommonAccountsAsync()
        {
            var commonAccounts = new List<CommonAccount>
            {
                new CommonAccount
                {
                    AccessNumber = "11111",
                    AccountNumber = "12345678",
                    AvailableBalance = 100,
                    Balance = 100,
                    Name = "test user 1"
                },
                new CommonAccount
                {
                    AccessNumber = "22222",
                    AccountNumber = "12121212",
                    AvailableBalance = 200,
                    Balance = 200,
                    Name = "test user 2"
                }
            };
            return Task.FromResult(commonAccounts);
        }

        public Task<List<CreditCard>> GetCreditCardsAsync()
        {
            var creditCards = new List<CreditCard>
            {
                new CreditCard
                {
                    AccessNumber = "33333",
                    CardNumber = "122434234",
                    ControlAccountNumber = "w234324",
                    CreditLimit = 1000,
                    InterestRate = 0.25m,
                    PrimaryAccountHolder = "test",
                    SecondaryAccountHolder = "test"
                },
                new CreditCard
                {
                    AccessNumber = "44444",
                    CardNumber = "32234324",
                    ControlAccountNumber = "w234324",
                    CreditLimit = 1000,
                    InterestRate = 0.2m,
                    PrimaryAccountHolder = "test",
                    SecondaryAccountHolder = "test"
                }
            };
            return Task.FromResult(creditCards);
        }
    }
}
