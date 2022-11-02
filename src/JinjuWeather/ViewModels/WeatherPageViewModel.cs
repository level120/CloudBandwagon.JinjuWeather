using System.Collections.ObjectModel;
using JinjuWeather.Mock;
using JinjuWeather.Models;

namespace JinjuWeather.ViewModels;

/// <summary>
/// <see cref="Pages.WeatherPage"/> ViewModel.
/// </summary>
public class WeatherPageViewModel : ViewModelBase
{
    public WeatherPageViewModel()
    {
        Week = new ObservableCollection<Forecast>(SampleDataGenerator.WeekEnumerable());
        Hours = new ObservableCollection<Forecast>(SampleDataGenerator.HourEnumerable());
    }

    public ObservableCollection<Forecast> Week { get; }

    public ObservableCollection<Forecast> Hours { get; }
}

