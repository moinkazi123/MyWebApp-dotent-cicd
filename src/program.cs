using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Set up Kestrel to listen on all network interfaces
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(5000); // Listen on port 5000
});

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.UseAuthorization();
app.MapControllers();
app.Run();
