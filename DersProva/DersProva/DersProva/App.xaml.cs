using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DersProva
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Buradaki MainPage program basladiginda acilacak sayfa, eger baska bir sayfanin ilk olarak acilmasini istiyorsak o sayfayi burada MainPage yerine yazmamiz gerekir.
            //App class'inda yazdigimiz kodlar butun programi etkiler.
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
