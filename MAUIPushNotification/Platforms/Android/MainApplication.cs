﻿using Android.App;
using Android.OS;
using Android.Runtime;
using Plugin.FirebasePushNotification;

namespace MAUIPushNotification;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override void OnCreate()
    {
        base.OnCreate();

        //Set the default notification channel for your app when running Android Oreo
        if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
        {
            //Change for your default notification channel id here
            FirebasePushNotificationManager.DefaultNotificationChannelId = "FirebasePushNotificationChannel";

            //Change for your default notification channel name here
            FirebasePushNotificationManager.DefaultNotificationChannelName = "General";

            FirebasePushNotificationManager.DefaultNotificationChannelImportance = NotificationImportance.Max;
        }

        //If debug you should reset the token each time.
#if DEBUG
        FirebasePushNotificationManager.Initialize(this, true);
#else
            FirebasePushNotificationManager.Initialize(this, false);
#endif

        //Handle notification when app is closed here
        CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
        {
            //ToDo: Business Logic when notification is received
            //HandleNotification();

        };
    }

}
