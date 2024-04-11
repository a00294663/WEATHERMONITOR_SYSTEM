namespace WeatherMonitoringSystem;
    /// <summary>
    /// Singleton class for collecting weather data and notifying observers.
    /// </summary>
    public class WeatherData
    {
        private static WeatherData instance;
        private readonly List<IDisplay> displays;
        private WeatherData()
        {
            displays = new List<IDisplay>();
        }

        public static WeatherData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WeatherData();
                }
                return instance;
            }
        }

        public void AddDisplay(IDisplay display)
        {
            displays.Add(display);
        }

        public void RemoveDisplay(IDisplay display)
        {
            displays.Remove(display);
        }

        public void NotifyObservers()
        {
            foreach (var display in displays)
            {
                display.Update();
            }
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            // Simulate setting weather data
            // This could be replaced with actual data collection logic
            // For simplicity, we just generate random values here
            Random random = new Random();
            temperature = random.Next(0, 40);
            humidity = random.Next(0, 100);
            pressure = random.Next(950, 1050);

            // Notify observers after setting new measurements
            NotifyObservers();
        }
    }
