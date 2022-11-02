using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace JinjuWeather.ViewModels;

/// <summary>
/// <see cref="AppShell"/> ViewModel.
/// </summary>
public class ShellViewModel : ViewModelBase
{
    public ShellViewModel()
    {
        OpenBrowserCommand = new Command<string>(OpenBrowser);
    }

    /// <summary>
    /// Open Browser Command.
    /// </summary>
    public ICommand OpenBrowserCommand { get; }

    private void OpenBrowser(string url)
    {
        _ = Browser.Default.OpenAsync(url, BrowserLaunchMode.SystemPreferred).ConfigureAwait(false);
    }
}

