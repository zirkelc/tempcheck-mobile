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
using TempCheckMobile.Services;
using ZXing.Mobile;
using TempCheckMobile.Droid.Services;

[assembly: Xamarin.Forms.Dependency(typeof(DroidPlatformService))]
namespace TempCheckMobile.Droid.Services
{
    public class DroidPlatformService : IPlatformService
    {
        public MobileBarcodeScanner GetMobileBarcodeScanner()
        {
            MobileBarcodeScanner.Initialize(MainActivity.MainApplication);

            return new MobileBarcodeScanner();
        }
    }
}