using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

//Bu class Android calisirken ilk olarak baslar

namespace DersProva.Droid
{
    [Activity(Label = "DersProva", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        //Android tarafi calistiginda ilk calisan method OnCreate methodudur.
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            //Bu kodla XamarinForms'u initialize ederiz
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //Portable tarafinda yapmis oldugumuz calismalari Android tarafina yukleyen method LoadApplication, parametre olarak da App class'ini veriyoruz.
            //Eger bu method olmazsa portable tarafinda yaptigimiz calismalar Android tarafinda calismaz.
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}