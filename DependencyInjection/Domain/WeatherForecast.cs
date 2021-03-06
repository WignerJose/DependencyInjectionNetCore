namespace DependencyInjection
{
    public class WeatherForecast
    {
        public int CityCode { get; set; }
        public string? CityName { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    }
}