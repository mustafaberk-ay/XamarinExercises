using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ActionContextDersi
{
    public partial class MainPage : ContentPage
    {
        public Person SelectedPerson { get; set; }
        public List<Person> People { get; set; }
        public MainPage()
        { 
            InitializeComponent();
            People = new List<Person>
            {
                new Person{Name="Ali", Surname="Kara"},
                new Person{Name="Murat", Surname="Ak"},
                new Person{Name="Ayse", Surname="Yilmaz"}
            };

            lstPerson.ItemsSource = People;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            DisplayAlert("Uyari", menuItem.CommandParameter + " Duzenle Tiklandi","Ok","Cancel");
        }

        private void MenuItem_Clicked_1(object sender, EventArgs e)
        {
            //sender'imizi menuItem olarak kullanabilmek icin MenuItem'a cast etmemiz gerekir.
            var menuItem = (MenuItem)sender;
            string name = menuItem.CommandParameter.ToString();
            //People'a git, people'in icindeki person'un name'i benim name'ime esit olan ilk itemi getirir.
            var selectedItem = People.Where(x => x.Name == name).FirstOrDefault();
            People.Remove(selectedItem);
            //ObservableCollection'da yapilan degisiklikler UI'ya hemen yansirken List'te yapilan degisiklikler hemen UI'ya yansimiyor.
            //Bu yuzden, UI'ya yansitmak icin bunu manuel olarak yapiyoruz.
            lstPerson.ItemsSource = null;
            lstPerson.ItemsSource = People;
        }
    }
}
