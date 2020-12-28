using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BindableDersi.CustomControls
{
    public class MyLabel : ContentView
    {
        Image image;
        public MyLabel()
        {
            image = new Image();
            image.WidthRequest = 300;
            image.HeightRequest = 300;
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(image);
            this.Content = stackLayout;
        }
        public BindableProperty ImageProperty = BindableProperty.Create("Image", typeof(string), typeof(MyLabel), null, propertyChanged:OnPropertyChanged);

        public string Image
        {
            get
            {
                return GetValue(ImageProperty).ToString();
            }
            set
            {
                SetValue(ImageProperty, value);
            }
        }
        private static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MyLabel)bindable;
            control.image.Source = newValue.ToString();
        }
    }
}
