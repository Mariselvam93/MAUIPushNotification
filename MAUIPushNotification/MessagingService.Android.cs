using Android.Gms.Common;
using Android.Gms.Tasks;
using Firebase.Iid;


namespace MAUIPushNotification
{
    public partial class MessagingService
    {
        public partial bool IsMessagingAvailable() => GoogleApiAvailability.Instance.IsGooglePlayServicesAvailable(Android.App.Application.Context) == ConnectionResult.Success;
        public partial string GetToken() => FirebaseInstanceId.Instance.Token;
        public partial void SetNewTokenCallback(Action<string> token_callback)
        {
            if (token_callback == null)
                throw new InvalidOperationException("Callback cannot be null");

            if (GetToken() != null)
                token_callback(GetToken());
            else
                FirebaseInstanceId.Instance.GetInstanceId().AddOnSuccessListener(new OnTokenListener((token) => token_callback(token)));
        }
    }

    public class OnTokenListener : Java.Lang.Object, IOnSuccessListener
    {
        Action<string> _callback;
        public OnTokenListener(Action<string> success_callback) => _callback = success_callback;
        public void OnSuccess(Java.Lang.Object result) => _callback?.Invoke(FirebaseInstanceId.Instance.Token);
    }
}
