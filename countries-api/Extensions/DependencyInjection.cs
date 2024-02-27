using countries_api.Settings;
using Polly;

namespace countries_api.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddConfiguredCors(this IServiceCollection services, IConfiguration configuration, string policy)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(name: policy,
                            policy =>
                            {
                                policy
                                    .WithOrigins(configuration.GetValue<string>("AllowedOrigins") ?? string.Empty)
                                    .AllowAnyHeader()
                                    .AllowAnyMethod();
                            });
        });
        return services;
    }

    public static IServiceCollection AddRestCountriesClient(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<RestCountriesOptions>(configuration.GetSection(RestCountriesOptions.RestCountries));
        services.AddHttpClient<RestCountriesService>()
            .AddTransientHttpErrorPolicy(policyBuilder => policyBuilder
                .WaitAndRetryAsync(3, retryNumber => TimeSpan.FromMilliseconds(600)));
        return services;
    }
}