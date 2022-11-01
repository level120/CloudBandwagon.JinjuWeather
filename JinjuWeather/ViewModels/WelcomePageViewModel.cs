using System;
using System.Windows.Input;
using JinjuWeather.Pages;

namespace JinjuWeather.ViewModels;

/// <summary>
/// <see cref="Pages.WelcomePage"/> ViewModel.
/// </summary>
public class WelcomePageViewModel : ViewModelBase
{
    private float _progress;
    private bool _isAnimated;

    public WelcomePageViewModel()
    {
        GoToCommand = new Command(GoTo);
    }

    /// <summary>
    /// Progress.
    /// </summary>
    public float Progress
    {
        get => _progress;
        set => SetProperty(ref _progress, value);
    }

    /// <summary>
    /// GIF Image Animated.
    /// </summary>
    public bool IsAnimated
    {
        get => _isAnimated;
        set => SetProperty(ref _isAnimated, value);
    }

    /// <summary>
    /// Goto Action Command.
    /// </summary>
    public ICommand GoToCommand { get; }

    private void GoTo()
    {
        IsAnimated = true;

        _ = GoToAsync().ConfigureAwait(false);
    }

    private async Task GoToAsync()
    {
        while (Progress < 1f)
        {
            Progress += 0.0075f;

            await Task.Delay(15);
        }

        MainThread.BeginInvokeOnMainThread(() =>
            _ = Shell.Current.GoToAsync($"//{nameof(WeatherPage)}", animate: true)
                             .ConfigureAwait(true));
    }
}
