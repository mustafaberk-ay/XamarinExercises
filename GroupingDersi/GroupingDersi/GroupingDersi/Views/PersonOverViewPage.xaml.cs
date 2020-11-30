using GroupingDersi.Models;
using GroupingDersi.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupingDersi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonOverViewPage : ContentPage
    {
        public PersonOverViewPage()
        {
            InitializeComponent();
            var data = new List<Person>();

            for(int i = 0; i < 50; i++)
            {
                data.Add(new Person(NameGenerator.GenRandomFirstName(), NameGenerator.GenRandomLastName(), "ID " + i));
            }

            var groupData = data.OrderBy(x => x.FirstName).GroupBy(x => x.FirstName[0].ToString()).Select(x => new ObservableGroupCollection<string, Person>(x)).ToList();
            this.BindingContext = new ObservableCollection<ObservableGroupCollection<string, Person>>(groupData);
        }
    }
}