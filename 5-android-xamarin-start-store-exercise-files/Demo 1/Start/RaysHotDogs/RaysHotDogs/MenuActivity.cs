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
    [Activity(Label = "MenuActivity", MainLauncher =true)]
    public class MenuActivity : Activity
    {
        private Button orderButton;
        private Button cartButton;
        private Button aboutButton;
        private Button mapButton;
        private Button takePictureButton;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainMenu);

            FindViews();

           
        }

        private void FindViews()
        {
            orderButton = FindViewById<Button>(Resource.Id.orderButton);
            cartButton = FindViewById<Button>(Resource.Id.cartButton);
            aboutButton = FindViewById<Button>(Resource.Id.aboutButton);
            mapButton = FindViewById<Button>(Resource.Id.mapButton);
            takePictureButton = FindViewById<Button>(Resource.Id.takePictureButton);
        }
    }
}