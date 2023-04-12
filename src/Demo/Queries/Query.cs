using Demo.Filters;
using Demo.Models;
using Demo.Services;

namespace Demo.Queries
{
    public class Query
    {
        [UseFiltering<AccountFilterType>()]
        public async Task<List<IAccount>> GetAccounts([Service] IAccountService accountService, string accessNumber)
        {
            var result = new List<IAccount>();
            var commonAccountsTask = accountService.GetCommonAccountsAsync();
            var creditCardsTask = accountService.GetCreditCardsAsync();
            await Task.WhenAll(commonAccountsTask, creditCardsTask);
            result.AddRange(commonAccountsTask.Result);
            result.AddRange(creditCardsTask.Result);
            return result.Where(x =>
                string.IsNullOrWhiteSpace(accessNumber) || x.AccessNumber.Contains(accessNumber)).ToList();
        }

        [UseFiltering<CommonAccountFilter>()]
        public async Task<List<CommonAccount>> GetCommonAccounts([Service] IAccountService accountService, string accessNumber, string name)
        {
            var result = await accountService.GetCommonAccountsAsync();
            return result.Where(x => string.IsNullOrWhiteSpace(accessNumber) || x.AccessNumber.Contains(accessNumber))
                .Where(x => string.IsNullOrWhiteSpace(name) || x.Name.Contains(name))
                .ToList();
        }

        [UseFiltering<CreditCardFilter>()]
        public async Task<List<CreditCard>> GetCreditCards([Service] IAccountService accountService, string accessNumber, string cardNumber,
            string controlAccountNumber)
        {
            var result = await accountService.GetCreditCardsAsync();
            return result.Where(x => string.IsNullOrWhiteSpace(accessNumber) || x.AccessNumber.Contains(accessNumber))
                .Where(x => string.IsNullOrWhiteSpace(cardNumber) || x.CardNumber.Contains(cardNumber))
                .Where(x => string.IsNullOrWhiteSpace(controlAccountNumber) ||
                            x.ControlAccountNumber.Contains(controlAccountNumber))
                .ToList();
        }

    }
}
