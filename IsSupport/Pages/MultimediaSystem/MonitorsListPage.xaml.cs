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
    /// Логика взаимодействия для MonitorsListPage.xaml
    /// </summary>
    public partial class MonitorsListPage : Page
    {
        List<Monitors> monitors = new List<Monitors>();
        public MonitorsListPage()
        {
            InitializeComponent();
            monitors=Helper.GetIsSupportContext().Monitors.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x=>x.Reload());
                DgrListMonitor.ItemsSource=Helper.GetIsSupportContext().Monitors.ToList();
            }
        }

        private void CmbListStatusDevice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var statusMonitor = (CmbListStatusDevice.SelectedItem as Monitors).ID;
            DgrListMonitor.ItemsSource = monitors.Where(x => x.StatusDeviceID == statusMonitor).ToList();
        }

        private void SearchBoxTitle_KeyUp(object sender, KeyEventArgs e)
        {
            var filter = monitors.Where(x => x.SerialNumber.ToUpperInvariant().Contains(SearchBoxTitle.Text.ToUpperInvariant()));
            DgrListMonitor.ItemsSource = filter;
        }

        private void BtnAddMonitor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MonitorAddPage());
        }

        private void BtnEditMonitor_Click(object sender, RoutedEventArgs e)
        {
            if(DgrListMonitor.SelectedItem is Monitors monitor)
            {
                NavigationService.Navigate(new MonitorAddPage(monitor));
            }
        }

        private void BtnCancelMonitor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
