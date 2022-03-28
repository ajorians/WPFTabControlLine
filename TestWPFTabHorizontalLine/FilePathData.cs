using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using static TestWPFTabHorizontalLine.Properties.Resources;

namespace TestWPFTabHorizontalLine
{
   public class FilePathData : INotifyPropertyChanged
   {
      public FilePathData()
      {
         FullFilePath = @"C:\Somewhere\whatever.txt";
         FileName = "Test.txt";
         DisplayName = IDS_DisplayName;
      }
      public string FullFilePath { get; }
      public string FileName { get; }
      public string DisplayName { get; }

      public string DateModified { get; private set; } = string.Empty;
      public DateTime DateLastUsed { get; set; } = DateTime.MinValue;
      private string _fileSize = string.Empty;
      public string FileSize { get => _fileSize; set => SetProperty( ref _fileSize, value ); }

      private bool SetProperty<T>( ref T currentValue, T newValue, [CallerMemberName] string propertyName = null )
      {
         currentValue = newValue;
         PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
         return true;
      }

      private string _toolTip;
      public string ToolTip { get => _toolTip; set => SetProperty( ref _toolTip, value ); }

      private string _duration;
      public string Duration { get => _duration; set => SetProperty( ref _duration, value ); }

      private BitmapImage _thumbnail;
      public BitmapImage Thumbnail { get => _thumbnail; set => SetProperty( ref _thumbnail, value ); }

      private bool _isSelected;
      public bool IsSelected { get => _isSelected; set => SetProperty( ref _isSelected, value ); }

      public event PropertyChangedEventHandler PropertyChanged;
   }
}