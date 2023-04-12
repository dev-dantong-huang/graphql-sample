using Demo.Models;
using Demo.Queries;
using Demo.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services
    .AddGraphQLServer()
    .AddFiltering()
    .AddQueryType<Query>()
    .AddType<IAccount>()
    .AddType<CommonAccount>()
    .AddType<CreditCard>();
var app = builder.Build();
app.MapGraphQL();

app.MapGet("/", () => "Hello World!");


app.Run();
