using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace TestWPFTabHorizontalLine
{
   public class CustomTabControl : TabControl
   {
      // <summary>
      // TabHeadersVisibility Dependency Property
      // </summary>
      public static readonly DependencyProperty TabHeadersVisibilityProperty =
                DependencyProperty.Register( nameof( TabHeadersVisibility ),
                                            typeof( Visibility ),
                                            typeof( CustomTabControl ),
                                            new PropertyMetadata( Visibility.Visible ) );

      public Visibility TabHeadersVisibility
      {
         get { return (Visibility)GetValue( TabHeadersVisibilityProperty ); }
         set { SetValue( TabHeadersVisibilityProperty, value ); }
      }

      public static readonly DependencyProperty TabUnderlineBrushProperty =
                DependencyProperty.Register( nameof( TabUnderlineBrush ),
                                            typeof( Brush ),
                                            typeof( CustomTabControl ),
                                            new PropertyMetadata( null ) );

      public Brush TabUnderlineBrush
      {
         get { return (Brush)GetValue( TabUnderlineBrushProperty ); }
         set { SetValue( TabUnderlineBrushProperty, value ); }
      }

      // <summary>
      // TabHeadersLineVisibility Dependency Property
      // </summary>
      public static readonly DependencyProperty TabHeadersLineVisibilityProperty =
                DependencyProperty.Register( nameof( TabHeadersLineVisibility ),
                                            typeof( Visibility ),
                                            typeof( CustomTabControl ),
                                            new PropertyMetadata( Visibility.Collapsed ) );

      public Visibility TabHeadersLineVisibility
      {
         get { return (Visibility)GetValue( TabHeadersLineVisibilityProperty ); }
         set { SetValue( TabHeadersLineVisibilityProperty, value ); }
      }

      public static readonly DependencyProperty TabHeaderlineBrushProperty =
                DependencyProperty.Register( nameof( TabHeaderlineBrush ),
                                            typeof( Brush ),
                                            typeof( CustomTabControl ),
                                            new PropertyMetadata( Brushes.Gray) );

      public Brush TabHeaderlineBrush
      {
         get { return (Brush)GetValue( TabHeaderlineBrushProperty ); }
         set { SetValue( TabHeaderlineBrushProperty, value ); }
      }

   }
}
