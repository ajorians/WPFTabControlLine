using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestWPFTabHorizontalLine
{
   public class VM : INotifyPropertyChanged
   {
      public VM( RecentContentViewModel recentContentViewModel )
      {
         RecentContentViewModel = recentContentViewModel;
      }
      public RecentContentViewModel RecentContentViewModel { get; }

      private int _selectedCollectionIndex = 0;
      public int SelectedCollectionIndex
      {
         get => _selectedCollectionIndex;
         set => SetProperty( ref _selectedCollectionIndex, value );
      }

      private bool SetProperty<T>( ref T currentValue, T newValue, [CallerMemberName] string propertyName = null )
      {
         currentValue = newValue;
         PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
         return true;
      }

      public event PropertyChangedEventHandler PropertyChanged;
   }
}
