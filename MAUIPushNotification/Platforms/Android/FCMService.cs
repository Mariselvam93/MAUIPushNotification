using Android.App;
using Android.Content;
using AndroidX.Core.App;
using Firebase.Messaging;

namespace MAUIPushNotification.Platforms.Android
{
    [Service(Exported = false)]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class FCMService : FirebaseMessagingService
    {
        public override void OnMessageReceived(RemoteMessage message)
        {
            RemoteMessage.Notification notification = message.GetNotification();

            IDictionary<string, string> data = message.Data;
            string body = "";
            string title = "";

            if (data != null && data.ContainsKey("body") && data.ContainsKey("title"))
            {
                body = data["body"];
                title = data["title"];
            }
            else if (notification != null)
            {
                body = message.GetNotification().Body;
                title = message.GetNotification().Title;
            }
            if (!string.IsNullOrEmpty(body) && !string.IsNullOrEmpty(title))
            {
                // TODO: Manage this message (we get here only when app is in foreground)
            }
        }
    }
}
