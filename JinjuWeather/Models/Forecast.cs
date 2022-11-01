namespace JinjuWeather.Models;

public class Forecast
{
    public DateTime DateTime { get; set; }

    public Temperature Temperature { get; set; }

    public Day Day { get; set; }

    public Night Night { get; set; }
}
