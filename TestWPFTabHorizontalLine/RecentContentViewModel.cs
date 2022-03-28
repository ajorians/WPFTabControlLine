using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TestWPFTabHorizontalLine
{
   public class RecentContentViewModel : INotifyPropertyChanged
   {
      public RecentContentViewModel()
      {
         _recentProjects = new ObservableCollection<FilePathData>()
         {
            new FilePathData(),
            new FilePathData(),
            new FilePathData()
         };

         _templates = new ObservableCollection<FilePathData>()
         {
            new FilePathData(),
            new FilePathData(),
            new FilePathData()
         };

         UpdateProjectCollections();
      }

      private void UpdateProjectCollections()
      {
         ProjectCollections.Clear();

         ProjectCollections.Add( new ProjectCollectionViewModel( _recentProjects.ToList() )
         {
            Title = "Recent Projects",
            NoDataEntriesMessage = "No Recent Projects",
            ShouldShowStartNewProject = true
         } );
         ProjectCollections.Add( new ProjectCollectionViewModel( Templates.ToList() )
         {
            Title = "Recent Templates",
            NoDataEntriesMessage = "No Recent Templates"
         } );
      }

      private ObservableCollection<FilePathData> _recentProjects;
      public ObservableCollection<FilePathData> RecentProjects => _recentProjects;
      private  ObservableCollection<FilePathData> _templates;
      public ObservableCollection<FilePathData> Templates => _templates;

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

      public ObservableCollection<ProjectCollectionViewModel> ProjectCollections { get; } = new();
      public event PropertyChangedEventHandler PropertyChanged;
   }
}