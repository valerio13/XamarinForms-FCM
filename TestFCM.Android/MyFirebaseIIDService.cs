using Android.App;
using Firebase.Iid;

namespace TestFCM.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class MyFirebaseIIDService : FirebaseInstanceIdService
    {
        const string TAG = "MyFirebaseIIDService";
        //        public override void OnTokenRefresh()
        //        {
        //            var refreshedToken = FirebaseInstanceId.Instance.Token;
        //            SendRegistrationToServer(refreshedToken);
        //        }

        //        void SendRegistrationToServer(string token)
        //        {
        //            // send this token to server
        //        }
        //    }
        //}



        public override void OnTokenRefresh()
        {
            // Get updated InstanceID token.
            var refreshedToken = FirebaseInstanceId.Instance.Token;
            Android.Util.Log.Debug(TAG, "Refreshed token: " + refreshedToken);
            System.Diagnostics.Debug.WriteLine($"######Token######  :  {refreshedToken}");
            Xamarin.Forms.Application.Current.Properties["Fcmtocken"] = FirebaseInstanceId.Instance.Token ?? "";
            Xamarin.Forms.Application.Current.SavePropertiesAsync();
        }
    }
}