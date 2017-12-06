
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
    [Activity(Label = "NewCityLayoutActivity")]
    public class NewCityLayoutActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.visitedLayout);
            ImageButton taipei = FindViewById<ImageButton>(Resource.Id.imageButton1);
            taipei.Click += delegate 
            {
                StartActivity(typeof(taipeiCityActivity));    
            };
            ImageButton seattle = FindViewById<ImageButton>(Resource.Id.imageButton2);
            seattle.Click += delegate 
            {
                StartActivity(typeof(seattleActivity));  
            };

            ImageButton newYork = FindViewById<ImageButton>(Resource.Id.imageButton3);
            newYork.Click +=delegate 
            {
                StartActivity(typeof(NewYorkActivity));    
            };
            // Create your application here
        }
    }
}
