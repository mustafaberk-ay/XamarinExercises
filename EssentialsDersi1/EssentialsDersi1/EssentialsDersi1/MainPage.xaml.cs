using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EssentialsDersi1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open(entryName.Text);
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
                DisplayAlert("Hata", anEx.Message.ToString(), "Tamam");
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
                DisplayAlert("Hata", ex.Message.ToString(), "Tamam");
            }
            catch (Exception ex)
            {
                // Other error has occurred.
                DisplayAlert("Hata", ex.Message.ToString(), "Tamam");
            }
        }
    }
}
