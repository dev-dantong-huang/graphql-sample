using Demo.Models;
using HotChocolate.Data.Filters;

namespace Demo.Filters
{
    public class CreditCardFilter : FilterInputType<CreditCard>
    {
        protected override void Configure(IFilterInputTypeDescriptor<CreditCard> descriptor)
        {
            descriptor.BindFieldsExplicitly();
            descriptor.Field(f => f.AccessNumber);
            descriptor.Field(f => f.CardNumber);
            descriptor.Field(f => f.ControlAccountNumber);
        }
    }
}
