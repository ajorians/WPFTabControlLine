﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace TestWPFTabHorizontalLine
{
   public class BoolToVisibilityConverter : IValueConverter
   {
      public BoolToVisibilityConverter()
      {
         TrueValue = Visibility.Visible;
         FalseValue = Visibility.Collapsed;
      }

      public Visibility TrueValue { get; set; }
      public Visibility FalseValue { get; set; }

      public object Convert( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
      {
         var val = System.Convert.ToBoolean( value );
         return val ? TrueValue : FalseValue;
      }

      public object ConvertBack( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
      {
         return TrueValue.Equals( value ) ? true : false;
      }
   }
}
