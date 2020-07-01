using ScanbotBarcodeSDK.Forms;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestBlankApp
{
    public partial class App : Application
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
        public App()
        {
            InitializeComponent();
            SBSDK.Initialize(new InitializationOptions
            {
                LicenseKey = licenseKey,
                LoggingEnabled = true,
                ErrorHandler = (status, feature) =>
                {
                    var message = $"Error! Status: {status}; Your license is missing the feature: {feature}";
                    Console.WriteLine(message);
                }
            });

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
