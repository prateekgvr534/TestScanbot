using ScanbotBarcodeSDK.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestBlankApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btn_Click(object sender, EventArgs e)
        {
            try
            {
                var configuration = new BarcodeScannerConfiguration();
                BarcodeResultBundle result = await SBSDK.Scanner.Open(configuration);
            }
            catch (Exception ex)
            {
                
            }
        }
        private async void btn_Click2(object sender, EventArgs e)
        {
            try
            {
                var configuration = new BarcodeScannerConfiguration();
                BarcodeResultBundle result = await SBSDK.Scanner.Open(configuration);
                //List<Barcode> barcodes = await SBSDK.Operations.DetectBarcodesFrom(result);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
