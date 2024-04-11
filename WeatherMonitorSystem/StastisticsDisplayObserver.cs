namespace WeatherMonitorSystem;
/// <summary>
    /// Concrete observer displaying weather statistics.
    /// </summary>
    public class StatisticsDisplay : IDisplay
    {
        public void Update()
        {
            // Update statistics display with latest weather data
            Console.WriteLine("Updating statistics display...");
        }
    }