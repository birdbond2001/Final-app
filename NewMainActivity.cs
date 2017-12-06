
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace travel
{
    [Activity(Label = "NewMainActivity" ,MainLauncher = true)]
    public class NewMainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button cityViewed = FindViewById<Button>(Resource.Id.button1);
            cityViewed.Click += delegate
            {
                StartActivity(typeof(NewCityLayoutActivity));

            };
            Button nextTravel = FindViewById<Button>(Resource.Id.button2);
            cityViewed.Click += delegate
            {
                StartActivity(typeof(NextTravelActivity));

            };



           

            Button btncall = FindViewById<Button>(Resource.Id.button4);
            btncall.Click += delegate
            {
                var uri2 = Android.Net.Uri.Parse("tel:6479611877");
                var callIntent = new Intent(Intent.ActionCall, uri2);
                StartActivity(callIntent);
            };

            Button btnemail = FindViewById<Button>(Resource.Id.button3);
            btnemail.Click += delegate
            {
                var email = new Intent(Android.Content.Intent.ActionSend);
                email.PutExtra(Android.Content.Intent.ExtraEmail,
                               new string[] {"birdbond2001@gmail.com","birdbond2001@gmail.com"
                });
                email.PutExtra(Android.Content.Intent.ExtraCc, new string[] { "birdbond2001@gmail.com" });
                email.PutExtra(Android.Content.Intent.ExtraSubject, "Test Email");
                email.PutExtra(Android.Content.Intent.ExtraText, "This is a test email ");
                email.SetType("message/rfc822");
                StartActivity(email);
            };
            // Create your application here
        }
    }
}
