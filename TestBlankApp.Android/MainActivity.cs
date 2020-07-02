using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using IO.Scanbot.Sdk.Barcode_scanner;

namespace TestBlankApp.Droid
{
    [Activity(Label = "TestBlankApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        const string licenseKey =
  "ZI8+mJ1Wuh/2SCsDC61vof2OCdSPUU" +
  "zkcRmFyI7ZqAuhFmlNcVXf+WKH3cGy" +
  "vUVovDpv9zkrX6jic+ELAktCf+vUU/" +
  "ttuKeYOdOo/3OiNxNUix0qas7Nb3Lb" +
  "1wmzcuMPE5Nuz3F/y5PZr9QcE+wnDw" +
  "X6sTz5fHe+88p1uMHkQEgGuLaf5qKx" +
  "b8nrUwaB4juPsHhI/VAs8HZ8yfaEan" +
  "wwRmNPY1dxSYHFcNz9iphxBz6nHXCL" +
  "Ugra401v1RuRbvvYrUTx8JsEomYIDy" +
  "LS1b9IOOo1uMTkoo/FdAoedZuwPxHo" +
  "W1IShvnck0tf2pPf7S2EXpTvHfLY9O" +
  "+2vZgjKkAUwA==\nU2NhbmJvdFNESw" +
  "pjb20uYWxwaGExbWFya2V0aW5nLktP" +
  "cmRlcgoxNTk1MDMwMzk5CjUxMgoz\n";
        protected override void OnCreate(Bundle savedInstanceState)
        {

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            ScanbotBarcodeSDK.Forms.Droid.DependencyManager.Register();
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
           
            //var initializer = new ScanbotBarcodeScannerSDKInitializer();
            //initializer.WithLogging(true);
            //// To run in trial mode, simply comment out the following line:
            //initializer.License((Application)Android.App.Application.Context, licenseKey);
            //initializer.Initialize((Application)Android.App.Application.Context);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}