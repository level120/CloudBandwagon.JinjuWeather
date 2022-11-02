using JinjuWeather.Models;

namespace JinjuWeather.Mock;

public class SampleDataGenerator
{
    public static IEnumerable<Forecast> WeekEnumerable()
    {
        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(1),
            Day = new Day { Phrase = "fluent_weather_sunny_high_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(11),
                Maximum = TemperatureUnit.Create(25),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(2),
            Day = new Day { Phrase = "fluent_weather_partly_cloudy" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(16),
                Maximum = TemperatureUnit.Create(27),
            }
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(3),
            Day = new Day { Phrase = "fluent_weather_rain_showers_day_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(16),
                Maximum = TemperatureUnit.Create(25),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(4),
            Day = new Day { Phrase = "fluent_weather_thunderstorm_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(13),
                Maximum = TemperatureUnit.Create(26),
            }
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(5),
            Day = new Day { Phrase = "fluent_weather_thunderstorm_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(9),
                Maximum = TemperatureUnit.Create(16),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(6),
            Day = new Day { Phrase = "fluent_weather_partly_cloudy" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(9),
                Maximum = TemperatureUnit.Create(20),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(7),
            Day = new Day { Phrase = "fluent_weather_rain_showers_day_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(8),
                Maximum = TemperatureUnit.Create(19),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(1),
            Day = new Day { Phrase = "fluent_weather_sunny_high_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(11),
                Maximum = TemperatureUnit.Create(25),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(2),
            Day = new Day { Phrase = "fluent_weather_partly_cloudy" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(16),
                Maximum = TemperatureUnit.Create(27),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(3),
            Day = new Day { Phrase = "fluent_weather_rain_showers_day_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(16),
                Maximum = TemperatureUnit.Create(28),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(4),
            Day = new Day { Phrase = "fluent_weather_thunderstorm_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(13),
                Maximum = TemperatureUnit.Create(26),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(5),
            Day = new Day { Phrase = "fluent_weather_thunderstorm_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(9),
                Maximum = TemperatureUnit.Create(16),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(6),
            Day = new Day { Phrase = "fluent_weather_partly_cloudy" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(9),
                Maximum = TemperatureUnit.Create(20),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Today.AddDays(7),
            Day = new Day { Phrase = "fluent_weather_rain_showers_day_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(8),
                Maximum = TemperatureUnit.Create(19),
            },
        };
    }

    public static IEnumerable<Forecast> HourEnumerable()
    {

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(1),
            Day = new Day { Phrase = "fluent_weather_rain_showers_day_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(47),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(2),
            Day = new Day { Phrase = "fluent_weather_rain_showers_day_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(47),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(3),
            Day = new Day { Phrase = "fluent_weather_rain_showers_day_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(48),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(4),
            Day = new Day { Phrase = "fluent_weather_rain_showers_day_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(49),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(5),
            Day = new Day { Phrase = "fluent_weather_cloudy_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(52),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(6),
            Day = new Day { Phrase = "fluent_weather_cloudy_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(53),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(7),
            Day = new Day { Phrase = "fluent_weather_cloudy_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(58),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(8),
            Day = new Day { Phrase = "fluent_weather_sunny_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(63),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(9),
            Day = new Day { Phrase = "fluent_weather_sunny_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(64),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(10),
            Day = new Day { Phrase = "fluent_weather_sunny_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(65),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(11),
            Day = new Day { Phrase = "fluent_weather_sunny_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(68),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(12),
            Day = new Day { Phrase = "fluent_weather_sunny_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(68),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(13),
            Day = new Day { Phrase = "fluent_weather_sunny_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(68),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(14),
            Day = new Day { Phrase = "fluent_weather_sunny_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(65),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(15),
            Day = new Day { Phrase = "fluent_weather_sunny_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(63),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(16),
            Day = new Day { Phrase = "fluent_weather_sunny_20_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(60),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(17),
            Day = new Day { Phrase = "fluent_weather_moon_16_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(58),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(18),
            Day = new Day { Phrase = "fluent_weather_moon_16_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(54),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(19),
            Day = new Day { Phrase = "fluent_weather_moon_16_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(53),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(20),
            Day = new Day { Phrase = "fluent_weather_moon_16_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(52),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(21),
            Day = new Day { Phrase = "fluent_weather_moon_16_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(50),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(22),
            Day = new Day { Phrase = "fluent_weather_moon_16_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(47),
                Maximum = TemperatureUnit.Create(67),
            },
        };

        yield return new Forecast
        {
            DateTime = DateTime.Now.AddHours(23),
            Day = new Day { Phrase = "fluent_weather_moon_16_filled" },
            Temperature = new Temperature
            {
                Minimum = TemperatureUnit.Create(47),
                Maximum = TemperatureUnit.Create(67),
            },
        };
    }
}

