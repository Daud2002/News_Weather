namespace Weather_and_News.Models
{
    public class WeatherInfo
    {
        public  string City { get; set; }
        public  string Temperature { get; set; }
        public  string Description { get; set; }
        public string Humidity { get; set; }
        public string WindSpeed { get; set; }

        public string Pressure { get; set; }
    }
    public class NewsArticle
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Text { get; set; }
    }


}
