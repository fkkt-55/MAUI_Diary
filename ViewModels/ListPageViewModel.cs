using diary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace diary.ViewModels
{
    public class ListPageViewModel : INotifyPropertyChanged
    {
        readonly IList<ListItem> source;

        ListItem selectedItem;

        public ObservableCollection<ListItem> ListItems { get; private set; } = new ObservableCollection<ListItem>();

        public ListItem SelectedListItem
        {
            get { return selectedItem; }

            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                }
            }
        }

        public ListPageViewModel()
        {
            source = new List<ListItem>();
            CreateCollection();

        }

        private void CreateCollection()
        {
            for (long i = 0; i < 10; i++)
            {
                ListItems.Add(new ListItem(i, new DateTime(), "Content"));
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
