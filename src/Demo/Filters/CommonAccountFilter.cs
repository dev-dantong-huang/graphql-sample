using Demo.Models;
using HotChocolate.Data.Filters;

namespace Demo.Filters
{
    public class CommonAccountFilter : FilterInputType<CommonAccount>
    {
        protected override void Configure(IFilterInputTypeDescriptor<CommonAccount> descriptor)
        {
            descriptor.BindFieldsExplicitly();
            descriptor.Field(f => f.AccessNumber);
            descriptor.Field(f => f.Name);
        }
    }
}
