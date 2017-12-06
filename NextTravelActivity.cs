
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
    [Activity(Label = "NextTravelActivity")]
    public class NextTravelActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.NEXT);
            Button cityViewed = FindViewById<Button>(Resource.Id.button1);
            cityViewed.Click += delegate
            {
                StartActivity(typeof(MainActivity));


                // Create your application here
            };
        }
    };
}
