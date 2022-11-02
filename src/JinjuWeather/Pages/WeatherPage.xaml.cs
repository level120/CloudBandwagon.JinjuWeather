using JinjuWeather.ViewModels;

namespace JinjuWeather.Pages;

public partial class WeatherPage : ContentPage
{
    public WeatherPage(WeatherPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}


