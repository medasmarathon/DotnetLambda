using System.Text.Json;
using Amazon.Lambda.Annotations;
using Microsoft.Extensions.DependencyInjection;
using RandomProductFunction;

[LambdaStartup]
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<RandomProductStore>();
        services.AddSwaggerGen();
    }
}