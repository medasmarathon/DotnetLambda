using Amazon.Lambda.Annotations;
using DotnetLambda.Persistence;
using Microsoft.Extensions.DependencyInjection;

[LambdaStartup]
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<RandomProductStore>();
        services.AddSwaggerGen();
    }
}