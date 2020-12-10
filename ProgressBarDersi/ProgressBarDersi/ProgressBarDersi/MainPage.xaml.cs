using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProgressBarDersi
{
    public partial class MainPage : ContentPage
    {
        //ProgressBar progressBar;
        public MainPage()
        {
            InitializeComponent();
            //progressBar = new ProgressBar();
            //progressBar.HeightRequest = 20;
            //progressBar.Progress = 0;

            //Button button = new Button();
            //button.Text = "Tikla";
            //button.Clicked += Button_Clicked;

            //StackLayout stackLayout = new StackLayout();
            //stackLayout.Children.Add(progressBar);
            //stackLayout.Children.Add(button);
            //this.Content = stackLayout;
        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    //1. Parametre ne kadar yuklenecegini belirtir. 0.8 yuzde 80 anlamina gelir.
        //    //2. Parametre ProgressBar'in yuklenme hizini ayarlamak icin kullanilir.
        //    //Easing(ProgressTo methodunun 3. parametresi) yuklenis goruntusunu ayarliyor
        //    await progressBar.ProgressTo(0.8, 500, Easing.Linear);
        //}

        //Yukaridaki constructor methodunu async yapamadigimizdan bu methodu yapiyoruz.
        //Xaml tarafindaki progressBar'i async calistaribilmek icin OnAppearing methodunu yaptik
        //OnAppearing methodu ekran acilir acilmaz UI'lari ekrana getirir
        protected override async void OnAppearing()
        {
            await progressBar.ProgressTo(0.8, 1000, Easing.Linear);
        }
    }
}
