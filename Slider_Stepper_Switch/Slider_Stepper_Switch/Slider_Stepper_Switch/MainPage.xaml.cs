using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Slider_Stepper_Switch
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void swtch1_Toggled(object sender, ToggledEventArgs e)
        {
            if (swtch1.IsToggled)
            {
                label.Text = "Acik";
            }
            else
            {
                label.Text = "Kapali";
            }
        }
    }
}
