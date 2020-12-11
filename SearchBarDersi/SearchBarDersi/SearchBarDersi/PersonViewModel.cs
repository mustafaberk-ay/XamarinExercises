using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SearchBarDersi
{
    public class PersonViewModel
    {
        public string Keyword { get; set; }
        public ICommand SearchCommand { get; set; }
        //public List<string> Results { get; set; }
        public ObservableCollection<string> Names { get; set; }


        public PersonViewModel()
        {
            SearchCommand = new Command(SearchAction);
            //Results = new List<string>();
            Names = new ObservableCollection<string>
            {
                "Ahmet", "Murat", "Necati", "Ayse", "Fatma", "Cenk", "Burak"
            };
        }

        private void SearchAction(object obj)
        {
            if(!string.IsNullOrEmpty(Keyword))
            {
                var result = Names.Where(x => x.ToLower().Contains(Keyword)).ToList();
                Names = new ObservableCollection<string>(result);
            }
        }
    }
}
