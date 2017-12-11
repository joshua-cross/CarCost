using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace CarCosts
{
    [Activity(Label = "CarCosts", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //getting the title from the application.
            TextView title = FindViewById<TextView>(Resource.Id.Test);
            //setting the title.
            try
            {
                title.Text = "Testing";
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

