using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SearchBarDersi
{
    public partial class MainPage : ContentPage
    {
        //private readonly List<string> _names = new List<string>
        //{
        //    "Ahmet", "Murat", "Necati", "Ayse", "Fatma", "Cenk", "Burak"
        //};
        public MainPage()
        {
            InitializeComponent();
            //lstPeople.ItemsSource = _names;
        }

        //private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var keyword = searchBar.Text;
        //    //Where fonksiyonu bir kosul fonksiyonudur. Burada _names listesinde x oyle ki x'in kucuk harflisi keyword'u icinde bulundurup bulundurmadigini kontrol eder.
        //    var result = _names.Where(x => x.ToLower().Contains(keyword));
        //    lstPeople.ItemsSource = result;
        //}

    }
}
