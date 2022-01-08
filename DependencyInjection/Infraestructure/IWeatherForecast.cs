namespace DependencyInjection.Infraestructure
{
    public interface IWeatherForecast
    {
        WeatherForecast? GetWeatherForecast(int cityCode);
    }
}
