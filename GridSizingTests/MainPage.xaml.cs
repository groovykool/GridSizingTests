using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GridSizingTests
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();

    }
      private void grid_Loaded(object sender, RoutedEventArgs e)
      {
        Grid sgrid = sender as Grid;
        TextBlock TB = new TextBlock();
        TB.Text = $"{sgrid.ActualWidth}, {sgrid.ActualHeight}";
        sgrid.Children.Add(TB);
      }

    private void SV1_Loaded(object sender, RoutedEventArgs e)
    {
      SV1.ChangeView(0, 0, 5f);
    }

    private void SV2_Loaded(object sender, RoutedEventArgs e)
    {
      SV2.ChangeView(0, 0, 5f);
    }
  }
}
