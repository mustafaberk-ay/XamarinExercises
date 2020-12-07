using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PickerDersi
{
    public partial class MainPage : ContentPage
    {
        public List<string> People { get; set; }

        public MainPage()
        {
            InitializeComponent();
            //Picker'da otomatik olarak secilen item'i eklemek icin bu kodu kullaniyoruz.
            //picker.SelectedItem = "Item 1";
            People = new List<string>
            {
                "Ali", "Ahmet", "Ayse", "Fatma", "Mehmet"
            };

            picker.ItemsSource = People;
            //picker.SelectedItem = People[0];
            picker.Title = "Kisiler";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(picker.SelectedItem != null)
            {
                DisplayAlert("Uyari", (string)picker.SelectedItem, "Tamam");

                #region Manual Item Adding
                //DisplayAlert("Uyari", "Secilen item: " + picker.SelectedItem, "Tamam");
                #endregion 
            }
        }

        //Picker'da sectigimiz eleman degistiginde bu event calisiyor.
        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAlert("Uyari", (string)picker.SelectedItem, "Tamam");
        }
    }
}
