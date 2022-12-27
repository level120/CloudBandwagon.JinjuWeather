using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;

namespace JinjuWeather;

public partial class App : Application
{
    public const string LogTag = "JinjuWeather";

    public App(AppShell shell)
    {
        InitializeComponent();

        MainPage = shell;
    }

    protected override void OnStart()
    {
        StartAppCenter();

        base.OnStart();

        Analytics.TrackEvent(nameof(OnStart));
    }

    private void StartAppCenter()
    {
        if (AppCenter.Configured)
        {
            return;
        }

        AppCenter.LogLevel = LogLevel.Debug;
        AppCenterLog.Info(LogTag, "AppCenter.LogLevel=" + AppCenter.LogLevel);
        AppCenterLog.Info(LogTag, "AppCenter.Configured=" + AppCenter.Configured);

        // Set callbacks
        Crashes.ShouldProcessErrorReport = ShouldProcess;
        Crashes.ShouldAwaitUserConfirmation = ConfirmationHandler;
        Crashes.GetErrorAttachments = GetErrorAttachmentsCallback;
        Distribute.ReleaseAvailable = OnReleaseAvailable;
        Distribute.WillExitApp = OnWillExitApp;
        Distribute.NoReleaseAvailable = OnNoReleaseAvailable;

        // Event handlers
        Crashes.SendingErrorReport += SendingErrorReportHandler;
        Crashes.SentErrorReport += SentErrorReportHandler;
        Crashes.FailedToSendErrorReport += FailedToSendErrorReportHandler;

        AppCenterLog.Assert(LogTag, "AppCenter.Configured=" + AppCenter.Configured);

        Distribute.UpdateTrack = UpdateTrack.Public;

        var appSecret = GetAppCenterTokenString();
        AppCenter.Start(appSecret, typeof(Analytics), typeof(Crashes), typeof(Distribute));

        AppCenter.IsEnabledAsync().ContinueWith(enabled =>
        {
            AppCenterLog.Info(LogTag, "AppCenter.Enabled=" + enabled.Result);
        });

        AppCenter.GetInstallIdAsync().ContinueWith(installId =>
        {
            AppCenterLog.Info(LogTag, "AppCenter.InstallId=" + installId.Result);
        });

        AppCenterLog.Info(LogTag, "AppCenter.SdkVersion=" + AppCenter.SdkVersion);

        Crashes.HasCrashedInLastSessionAsync().ContinueWith(hasCrashed =>
        {
            AppCenterLog.Info(LogTag, "Crashes.HasCrashedInLastSession=" + hasCrashed.Result);
        });

        Crashes.GetLastSessionCrashReportAsync().ContinueWith(task =>
        {
            AppCenterLog.Info(LogTag, "Crashes.LastSessionCrashReport.StackTrace=" + task.Result?.StackTrace);
        });
    }

    private static string GetAppCenterTokenString()
    {
        var appSecretKey = "cc8928e2-681f-4366-8b26-0d2c80fccfd0";

        return $"ios={appSecretKey};" +
               $"macos={appSecretKey};" +
               $"android={appSecretKey}";
    }

    private static void SendingErrorReportHandler(object sender, SendingErrorReportEventArgs e)
    {
        AppCenterLog.Info(LogTag, "Sending error report");
    }

    private static void SentErrorReportHandler(object sender, SentErrorReportEventArgs e)
    {
        AppCenterLog.Info(LogTag, "Sent error report");
    }

    private static void FailedToSendErrorReportHandler(object sender, FailedToSendErrorReportEventArgs e)
    {
        AppCenterLog.Info(LogTag, "Failed to send error report");
    }

    private bool ShouldProcess(ErrorReport report)
    {
        AppCenterLog.Info(LogTag, "Determining whether to process error report");
        return true;
    }

    private bool ConfirmationHandler()
    {
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            string answer;

            if (DeviceInfo.Platform == DevicePlatform.macOS)
            {
                answer = await Current.MainPage.DisplayActionSheet("Crash detected. Send anonymous crash report?", "Send", "Always Send");
            }
            else
            {
                answer = await Current.MainPage.DisplayActionSheet("Crash detected. Send anonymous crash report?", null, null, "Send", "Always Send", "Don't Send");
            }

            UserConfirmation userConfirmationSelection;

            if (answer == "Send")
            {
                userConfirmationSelection = UserConfirmation.Send;
            }
            else if (answer == "Always Send")
            {
                userConfirmationSelection = UserConfirmation.AlwaysSend;
            }
            else
            {
                userConfirmationSelection = UserConfirmation.DontSend;
            }

            AppCenterLog.Debug(LogTag, "User selected confirmation option: \"" + answer + "\"");
            Crashes.NotifyUserConfirmation(userConfirmationSelection);
        });
        return true;
    }

    private static IEnumerable<ErrorAttachmentLog> GetErrorAttachmentsCallback(ErrorReport report)
    {
        return Enumerable.Empty<ErrorAttachmentLog>();
    }

    private void OnNoReleaseAvailable()
    {
        AppCenterLog.Info(LogTag, "No release available callback invoked.");
    }

    private bool OnReleaseAvailable(ReleaseDetails releaseDetails)
    {
        AppCenterLog.Info(LogTag, "OnReleaseAvailable id=" + releaseDetails.Id
                                        + " version=" + releaseDetails.Version
                                        + " releaseNotesUrl=" + releaseDetails.ReleaseNotesUrl);
        var custom = releaseDetails.ReleaseNotes?.ToLowerInvariant().Contains("custom") ?? false;
        if (custom)
        {
            var title = "Version " + releaseDetails.ShortVersion + " available!";
            Task answer;
            if (releaseDetails.MandatoryUpdate)
            {
                answer = Current.MainPage.DisplayAlert(title, releaseDetails.ReleaseNotes, "Update now!");
            }
            else
            {
                answer = Current.MainPage.DisplayAlert(title, releaseDetails.ReleaseNotes, "Update now!", "Maybe tomorrow...");
            }
            answer.ContinueWith((task) =>
            {
                if (releaseDetails.MandatoryUpdate || ((Task<bool>)task).Result)
                {
                    Distribute.NotifyUpdateAction(UpdateAction.Update);
                }
                else
                {
                    Distribute.NotifyUpdateAction(UpdateAction.Postpone);
                }
            });
        }
        return custom;
    }

    private void OnWillExitApp()
    {
        AppCenterLog.Info(LogTag, "App will close callback invoked.");
    }
}

