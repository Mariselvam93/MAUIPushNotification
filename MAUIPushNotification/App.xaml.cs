using Plugin.FirebasePushNotification;

namespace MAUIPushNotification;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

        CrossFirebasePushNotification.Current.Subscribe("all");
        CrossFirebasePushNotification.Current.OnTokenRefresh += Current_OnTokenRefresh;
        //CrossFirebasePushNotification.Current.NotificationHandler            
        CrossFirebasePushNotification.Current.OnNotificationAction += Current_OnNotificationAction;
        CrossFirebasePushNotification.Current.OnNotificationOpened += Current_OnNotificationOpened;
        CrossFirebasePushNotification.Current.OnNotificationReceived += Current_OnNotificationReceived;
        CrossFirebasePushNotification.Current.OnNotificationDeleted += Current_OnNotificationDeleted;
   }

    private void Current_OnNotificationDeleted(object source, FirebasePushNotificationDataEventArgs e)
    {

    }

    private void Current_OnNotificationReceived(object source, FirebasePushNotificationDataEventArgs e)
    {

    }

    private void Current_OnNotificationOpened(object source, FirebasePushNotificationResponseEventArgs e)
    {

    }

    private void Current_OnNotificationAction(object source, FirebasePushNotificationResponseEventArgs e)
    {

    }

    private void Current_OnTokenRefresh(object source, FirebasePushNotificationTokenEventArgs e)
    {
        System.Diagnostics.Debug.WriteLine($"Token: {e.Token}");
    }
}
