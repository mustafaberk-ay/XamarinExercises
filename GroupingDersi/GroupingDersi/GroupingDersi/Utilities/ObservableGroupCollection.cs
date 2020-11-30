using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GroupingDersi.Utilities
{
    public class ObservableGroupCollection<S, T> : ObservableCollection<T>
    {
        //Buradaki kodlamalar ile key'i olusturuyoruz.
        private readonly S _key;

        public ObservableGroupCollection(IGrouping<S,T> group):base(group)
        {
            _key = group.Key;
        }
        //Property olan Key'i xaml'da kullanacagiz. 
        public S Key { get { return _key; } }
    }
}
