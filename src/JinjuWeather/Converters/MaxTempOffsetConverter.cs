﻿using System.Globalization;

namespace JinjuWeather.Converters;

public class MaxTempOffsetConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        const double max = 58 * 3 / 1.8;

        var maxTemp = System.Convert.ToDouble(value) * 3;
        var topMargin = max - maxTemp;

        return new Thickness(0, topMargin, 0, 0);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}