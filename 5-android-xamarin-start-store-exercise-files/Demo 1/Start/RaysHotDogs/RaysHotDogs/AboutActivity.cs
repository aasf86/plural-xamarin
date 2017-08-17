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

namespace RaysHotDogs
{
    [Activity(Label = "About Ray's Hot Dogs")]
    public class AboutActivity : Activity
    {
        private TextView phoneNumberTextView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.AboutView);

            FindViews();
        }

        private void FindViews()
        {
            phoneNumberTextView = FindViewById<TextView>(Resource.Id.phoneNumberTextView);
        }

    }
}