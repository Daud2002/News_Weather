namespace Weather_and_News.Models
{
    public class OpenWeatherResponse
    {
        public string Name { get; set; } // City name
        public MainData Main { get; set; }
        public List<WeatherData> Weather { get; set; }
        public WindData Wind { get; set; } // Add WindData property
        public int Humidity { get; set; } // Add Humidity property
        public int Pressure { get; set; } // Add Pressure property
    }

    public class MainData
    {
        public float Temp { get; set; } // Temperature in Celsius
        public int Humidity { get; set; } // Humidity percentage
        public int Pressure { get; set; } // Pressure in hPa
    }

    public class WeatherData
    {
        public string Description { get; set; } // Weather description (e.g., "Clear sky")
    }

    public class WindData
    {
        public float Speed { get; set; } // Wind speed in meters per second
    }
}
