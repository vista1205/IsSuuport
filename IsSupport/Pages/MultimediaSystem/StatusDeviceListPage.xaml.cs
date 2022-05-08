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
    /// Логика взаимодействия для StatusDeviceListPage.xaml
    /// </summary>
    public partial class StatusDeviceListPage : Page
    {
        public StatusDeviceListPage()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnEditStatus_Click(object sender, RoutedEventArgs e)
        {
            if(DgrStatusList.SelectedItem is StatusDevice status)
            {
                NavigationService.Navigate(new StatusDeviceAddPage(status));
            }
        }

        private void BtnAddStatus_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StatusDeviceAddPage());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DgrStatusList.ItemsSource = Helper.GetIsSupportContext().StatusDevice.ToList();
            }
        }
    }
}
