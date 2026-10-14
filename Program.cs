using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using JPTrading.Web;
using JPTrading.Web.Services;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();

builder.Services.AddScoped<ApiService>();
builder.Services.AddScoped<VehicleService>();
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<AuctionSheetService>();
builder.Services.AddScoped<CurrencyService>();

await builder.Build().RunAsync();