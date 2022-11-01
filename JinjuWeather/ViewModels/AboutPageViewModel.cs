using System;

namespace JinjuWeather.ViewModels;

/// <summary>
/// <see cref="Pages.AboutPage"/> ViewModel.
/// </summary>
public class AboutPageViewModel : ViewModelBase
{
    private IAppInfo _appInfo;

    public AboutPageViewModel()
    {
        ApplicationInfo = AppInfo.Current;
    }

    public IAppInfo ApplicationInfo
    {
        get => _appInfo;
        set => SetProperty(ref _appInfo, value);
    }
}

