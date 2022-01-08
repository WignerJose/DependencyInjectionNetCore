namespace DependencyInjection.Infraestructure
{
    public class WeatherForecastRepository : IWeatherForecast
    {
        private static readonly WeatherForecast[] Summaries = { new WeatherForecast() { CityCode = 100,Date = DateTime.Now, CityName = "Cochabamba", TemperatureC = 28, } ,
                                                                new WeatherForecast() { CityCode = 200,Date = DateTime.Now, CityName = "Santa Cruz", TemperatureC = 32,},
                                                                new WeatherForecast() { CityCode = 300,Date = DateTime.Now, CityName = "Sucre", TemperatureC = 21,},
                                                                new WeatherForecast() { CityCode = 400,Date = DateTime.Now, CityName = "Potosi", TemperatureC = 16,},
                                                                new WeatherForecast() { CityCode = 500,Date = DateTime.Now, CityName = "La paz", TemperatureC = 11,}, };

        public  WeatherForecast? GetWeatherForecast(int cytiCode)
        {
            return Summaries.FirstOrDefault(city => city.CityCode.Equals(cytiCode));
        }
    }

}
