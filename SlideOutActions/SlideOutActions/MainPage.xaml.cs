using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace SlideOutActions
{
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<object> Itemslist
        {
            get { return (ObservableCollection<object>)GetValue(ItemslistProperty); }
            set { SetValue(ItemslistProperty, value); }
        }

        public static readonly DependencyProperty ItemslistProperty =
            DependencyProperty.Register("Itemslist", typeof(ObservableCollection<object>), typeof(MainPage), new PropertyMetadata(new ObservableCollection<object>()));


        public MainPage()
        {
            this.InitializeComponent();
            Itemslist = new ObservableCollection<object>();

            for (int i = 0; i < 20; i++)
            {
                Itemslist.Add("this is item " + (i+1).ToString());
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var button = sender as Button;
            var item = button.DataContext.ToString();

            Itemslist.Remove(item);
        }
    }
}
