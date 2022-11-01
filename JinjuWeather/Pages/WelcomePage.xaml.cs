using JinjuWeather.ViewModels;

namespace JinjuWeather.Pages;

public partial class WelcomePage : ContentPage
{
    public WelcomePage(WelcomePageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}
