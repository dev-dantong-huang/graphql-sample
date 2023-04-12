using Demo.Models;
using HotChocolate.Data.Filters;

namespace Demo.Filters
{
    public class AccountFilterType : FilterInputType<IAccount>
    {
        protected override void Configure(IFilterInputTypeDescriptor<IAccount> descriptor)
        {
            descriptor.BindFieldsExplicitly();
            descriptor.Field(f => f.AccessNumber);
        }
    }
}
