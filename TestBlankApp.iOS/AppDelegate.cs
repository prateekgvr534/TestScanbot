using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using ScanbotBarcodeSDK.iOS;
using UIKit;

namespace TestBlankApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public static nfloat TopInset { get; private set; }

        public UINavigationController Controller { get; set; }

        public UIWindow Window { get; set; }
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
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        [Export("application:didFinishLaunchingWithOptions:")]
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            ScanbotSDK.SetLicense(licenseKey);
            ScanbotSDK.SetLoggingEnabled(true);

            return base.FinishedLaunching(app, options);
        }
    }
}
