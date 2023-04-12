using Demo.Models;

namespace Demo.Services
{
    public interface IAccountService
    {
        Task<List<CommonAccount>> GetCommonAccountsAsync();
        Task<List<CreditCard>> GetCreditCardsAsync();
    }
}
