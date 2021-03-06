using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IsSupport.Pages.MultimediaSystem
{
    /// <summary>
    /// Логика взаимодействия для KeyboardsListPage.xaml
    /// </summary>
    public partial class KeyboardsListPage : Page
    {
        List<Keyboards> keyboard = new List<Keyboards>();
        public KeyboardsListPage()
        {
            InitializeComponent();
            keyboard = Helper.GetIsSupportContext().Keyboards.ToList();
            CmbListStatusDevice.ItemsSource = Helper.GetIsSupportContext().StatusDevice.ToList();
        }

        private void CmbListStatusDevice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var statusKeyboards = (CmbListStatusDevice.SelectedItem as StatusDevice).ID;
            var filter = keyboard.Where(x => x.StatusDeviceID == statusKeyboards);
            DgrListKeyboards.ItemsSource = filter;
        }

        private void BtnAddKeyboard_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new KeyboardsAddPage());
        }

        private void BtnEditKeyboard_Click(object sender, RoutedEventArgs e)
        {
            if(DgrListKeyboards.SelectedItem is Keyboards keyboard)
            {
                NavigationService.Navigate(new KeyboardsAddPage(keyboard));
            }
        }

        private void BtnCancelKeyboard_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DgrListKeyboards.ItemsSource = Helper.GetIsSupportContext().Keyboards.ToList();
            }
        }

        private void SearchBoxTitle_KeyUp(object sender, KeyEventArgs e)
        {
            var filter = keyboard.Where(x => x.SerialNumber.ToUpperInvariant().Contains(SearchBoxTitle.Text.ToUpperInvariant()));
            DgrListKeyboards.ItemsSource = filter;
        }
    }
}
