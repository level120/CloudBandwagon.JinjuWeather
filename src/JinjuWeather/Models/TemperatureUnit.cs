namespace JinjuWeather.Models;

public readonly struct TemperatureUnit : IEquatable<TemperatureUnit>
{
    public readonly int Value;
    public readonly string Unit;

    public TemperatureUnit(int value, string unit)
    {
        Value = value;
        Unit = unit;
    }

    public static TemperatureUnit Create(int value, string unit = "C")
    {
        return new TemperatureUnit(value, unit);
    }

    public bool Equals(TemperatureUnit other)
    {
        return Value == other.Value && Unit == other.Unit;
    }
}