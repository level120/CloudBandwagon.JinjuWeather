namespace JinjuWeather.Models;

public class TemperatureUnit
{
    public TemperatureUnit(int value, string unit)
    {
        Value = value;
        Unit = unit;
    }

    public int Value { get; }

    public string Unit { get; }

    public static TemperatureUnit Create(int value, string unit = "C")
    {
        return new TemperatureUnit(value, unit);
    }
}