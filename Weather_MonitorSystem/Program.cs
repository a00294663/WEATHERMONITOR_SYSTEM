using System;

namespace WeatherMonitoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the weather station
            WeatherStation weatherStation = new WeatherStation();

            // Create displays using the factory
            IDisplay currentConditionsDisplay = weatherStation.CreateDisplay(DisplayType.CurrentConditions);
            IDisplay statisticsDisplay = weatherStation.CreateDisplay(DisplayType.Statistics);
            IDisplay forecastDisplay = weatherStation.CreateDisplay(DisplayType.Forecast);

            // Subscribe displays to weather data changes
            weatherStation.WeatherDataChanged += currentConditionsDisplay.Update;
            weatherStation.WeatherDataChanged += statisticsDisplay.Update;
            weatherStation.WeatherDataChanged += forecastDisplay.Update;

            // Simulate weather data changes (for demonstration purposes)
            RandomWeatherGenerator randomWeatherGenerator = new RandomWeatherGenerator();
            for (int i = 0; i < 10; i++)
            {
                WeatherData.Instance.SetMeasurements(randomWeatherGenerator.GenerateTemperature(), randomWeatherGenerator.GenerateHumidity(), randomWeatherGenerator.GeneratePressure());
                System.Threading.Thread.Sleep(1000); // Simulate 1 second delay between data updates
            }
        }
    }
}