namespace WeatherMonitorSystem;
 /// <summary>
    /// Concrete observer displaying current weather conditions.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        public void Update()
        {
            // Update current conditions display with latest weather data
            Console.WriteLine("Updating current conditions display...");
        }
    }