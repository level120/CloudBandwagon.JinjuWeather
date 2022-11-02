using JinjuWeather.ViewModels;

namespace JinjuWeather.Pages;

public partial class AboutPage : ContentPage
{
    public AboutPage(AboutPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}
