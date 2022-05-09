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
    /// Логика взаимодействия для SystemUnitsListPage.xaml
    /// </summary>
    public partial class SystemUnitsListPage : Page
    {
        List<SystemUnits> unitsList = new List<SystemUnits>();
        public SystemUnitsListPage()
        {
            InitializeComponent();
            CmbListStatusDevice.ItemsSource=Helper.GetIsSupportContext().StatusDevice.ToList();
            unitsList=Helper.GetIsSupportContext().SystemUnits.ToList();
            DgrListSystemUnit.ItemsSource = unitsList;
        }

        private void SearchBoxSerial_KeyUp(object sender, KeyEventArgs e)
        {
            var filter = unitsList.Where(x => x.SeralNumber.ToUpperInvariant().Contains(SearchBoxSerial.Text.ToUpperInvariant()));
            DgrListSystemUnit.ItemsSource = filter;
        }
        private void SearchBoxInvent_KeyUp(object sender, KeyEventArgs e)
        {
            var filter = unitsList.Where(x => x.InventoryNumber.ToUpperInvariant().Contains(SearchBoxInvent.Text.ToUpperInvariant()));
            DgrListSystemUnit.ItemsSource = filter;
        }

        private void BtnAddSystemUnit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SystemUnitAddPage());
        }

        private void BtnEditSystemUnit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancelSystemUnit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CmbListStatusDevice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var idStatus = (CmbListStatusDevice.SelectedItem as StatusDevice).ID;
            DgrListSystemUnit.ItemsSource=unitsList.Where(x=>x.StatusDeviceID==idStatus).ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DgrListSystemUnit.ItemsSource = unitsList;
            }
        }
    }
}
