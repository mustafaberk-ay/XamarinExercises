using GroupingDersi.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupingDersi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PersonOverViewPage());
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
