namespace WeatherMonitoringSystem{
/// <summary>
    /// Factory for creating different types of displays.
    /// </summary>
    public class WeatherStation
    {
        public IDisplay CreateDisplay(string type)
        {
            switch (type)
            {
                case "CurrentConditions":
                    return new CurrentConditionsDisplay();
                case "Statistics":
                    return new StatisticsDisplay();
                case "Forecast":
                    return new ForecastDisplay();
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }
}
    