using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TestWPFTabHorizontalLine
{
   public class ProjectCollectionViewModel : INotifyPropertyChanged
   {
      public ProjectCollectionViewModel( IEnumerable<FilePathData> filePathDataCollection )
      {
         FilePathDataCollection = filePathDataCollection ?? throw new ArgumentNullException( nameof( filePathDataCollection ) );

         ShouldShowStartNewProject = true;
      }

      public string Title { get; set; }

      public string NoDataEntriesMessage { get; set; }

      public bool ShouldShowStartNewProject { get; set; }

      public IEnumerable<FilePathData> FilePathDataCollection { get; }

      public bool FilePathDataAvailable => FilePathDataCollection.Any();

      private FilePathData _selectedFilePathData;
      public FilePathData SelectedFilePathData
      {
         get => _selectedFilePathData;
         set
         {
            if ( SetProperty( ref _selectedFilePathData, value ) )
            {
               UpdateSelectedFilePathData();
            }
         }
      }

      private bool SetProperty<T>( ref T currentValue, T newValue, [CallerMemberName] string propertyName = null )
      {
         currentValue = newValue;
         PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
         return true;
      }

      private void UpdateSelectedFilePathData()
      {
         foreach ( var filePathData in FilePathDataCollection )
         {
            if ( filePathData == SelectedFilePathData )
            {
               filePathData.IsSelected = true;
            }
            else
            {
               filePathData.IsSelected = false;
            }
         }
      }


      public event PropertyChangedEventHandler PropertyChanged;
   }
}