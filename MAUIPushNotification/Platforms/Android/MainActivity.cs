using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Plugin.FirebasePushNotification;

namespace MAUIPushNotification;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        
        //Maui.Essentials.Platform.Init(this, savedInstanceState);
        /*global::Xamarin.Forms.Forms.Init(this, savedInstanceState)*/;
        //LoadApplication(new App());

        Firebase.FirebaseApp.InitializeApp(this);
        FirebasePushNotificationManager.ProcessIntent(this, Intent);
    }
    //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
    //{
    //    //Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

    //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    //}
}
