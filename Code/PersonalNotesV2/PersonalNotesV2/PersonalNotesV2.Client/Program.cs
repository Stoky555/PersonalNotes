using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PersonalNotesV2.Client;
using PersonalNotesV2.Client.Repository;
using PersonalNotesV2.Client.Services;
using PersonalNotesV2.Shared.TodoItemRepository;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddScoped<ITodoItemRepository, TodoItemService>();
builder.Services.AddScoped<IBlogRepository, BlogService>();

await builder.Build().RunAsync();
