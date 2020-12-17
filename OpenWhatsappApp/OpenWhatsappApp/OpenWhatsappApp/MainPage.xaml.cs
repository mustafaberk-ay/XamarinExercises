using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 
using Xamarin.Forms.OpenWhatsApp;

namespace OpenWhatsappApp
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
                Chat.Open(entryName.Text, "Send this message");
            }
            catch (Exception ex)
            {
                DisplayAlert("Uyari", ex.Message, "Tamam");
            }
        }
    }
}
