using System.Globalization;

namespace JinjuWeather.Converters;

public class MinTempOffsetConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        const double min = 8 * 3 / 1.8;

        var minTemp = System.Convert.ToDouble(value) * 3;
        var bottomMargin = minTemp - min;

        return new Thickness(0, 0, 0, bottomMargin);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}