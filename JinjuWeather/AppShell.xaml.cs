using JinjuWeather.ViewModels;

namespace JinjuWeather;

public partial class AppShell : Shell
{
    public AppShell(ShellViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}

