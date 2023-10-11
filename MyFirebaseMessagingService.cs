using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Firebase.Messaging;

namespace AndroidApp2
{
	[Service(Exported = false)]
	[IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
	public class MyFirebaseMessagingService : FirebaseMessagingService
	{
		public override void OnMessageReceived(RemoteMessage message)
		{
            System.Diagnostics.Debug.WriteLine("OnMessageReceived");
		}

		public override void OnNewToken(string p0)
		{
            System.Diagnostics.Debug.WriteLine("OnNewToken");

            base.OnNewToken(p0);
		}
	}
}