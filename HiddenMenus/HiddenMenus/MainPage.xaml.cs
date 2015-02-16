using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace HiddenMenus
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LeftButtonTapped_Tapped(object sender, TappedRoutedEventArgs e)
        {
            slidein.GoToMenuState(ActiveState.Left);
        }

        private void RightButtonTapped_Tapped(object sender, TappedRoutedEventArgs e)
        {
            slidein.GoToMenuState(ActiveState.Right);
        }

        private async void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            slidein.GoToMenuState(ActiveState.Center);

        }
    }
}
