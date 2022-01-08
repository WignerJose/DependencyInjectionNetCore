using DependencyInjection.Infraestructure;

namespace DependencyInjection.Sharedkernel
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecast, WeatherForecastRepository>();
            return services;
        }
    }
}
