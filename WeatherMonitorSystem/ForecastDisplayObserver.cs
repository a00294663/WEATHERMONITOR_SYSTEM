namespace WeatherMonitorSystem;
/// <summary>
    /// Concrete observer displaying weather forecast.
    /// </summary>
    public class ForecastDisplay : IDisplay
    {
        public void Update()
        {
            // Update forecast display with latest weather data
            Console.WriteLine("Updating forecast display...");
        }
    }