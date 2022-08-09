using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OnlineShop.Web;
using OnlineShop.Web.Services;
using OnlineShop.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7012/") });

await builder.Build().RunAsync();
