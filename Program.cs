using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DynamicFormGenerator;
using MudBlazor.Services;
using MudBlazor;
using System.Text.Json;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
});

// Adding MudServices
builder.Services.AddMudServices();

await builder.Build().RunAsync();
