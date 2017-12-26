using System.Collections.Generic;
using System.Collections.ObjectModel;
using GroupingListViewSample.Models;

namespace GroupingListViewSample.ViewModels
{
    public class PhoneGroup : ObservableCollection<Phone>
    {
        public string Name { get; private set; }

        public PhoneGroup(string name)
            : base()
        {
            Name = name;
        }

        public PhoneGroup(string name, IEnumerable<Phone> source)
            : base(source)
        {
            Name = name;
        }
    }
}