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
    /// Логика взаимодействия для EquipmentsListPage.xaml
    /// </summary>
    public partial class EquipmentsListPage : Page
    {
        public EquipmentsListPage()
        {
            InitializeComponent();
            CmbStatusDeviceList.ItemsSource=Helper.GetIsSupportContext().StatusDevice.ToList();
            CmbTypeEquipmentList.ItemsSource=Helper.GetIsSupportContext().TypesEquipment.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DgrEquipmentsList.ItemsSource=Helper.GetIsSupportContext().Equipments.ToList();
            }
        }

        private void CmbTypeEquipmentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var filter = (CmbTypeEquipmentList.SelectedItem as TypesEquipment).ID;
            DgrEquipmentsList.ItemsSource=Helper.GetIsSupportContext().Equipments.Where(x=>x.TypeEquipmentID==filter).ToList();
        }

        private void CmbStatusDeviceList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var filter = (CmbStatusDeviceList.SelectedItem as StatusDevice).ID;
            DgrEquipmentsList.ItemsSource = Helper.GetIsSupportContext().Equipments.Where(x => x.StatusDeviceID == filter).ToList();
        }

        private void TbSearchSN_KeyUp(object sender, KeyEventArgs e)
        {
            DgrEquipmentsList.ItemsSource = Helper.GetIsSupportContext().Equipments.Where(x => x.SerialNumber.ToUpperInvariant().Contains(TbSearchSN.Text.ToUpperInvariant())).ToList();
        }

        private void BtnAddEquipments_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EquipmentsAddPage());
        }

        private void BtnEditEquipments_Click(object sender, RoutedEventArgs e)
        {
            if(DgrEquipmentsList.SelectedItem is Equipments equipments)
            {
                NavigationService.Navigate(new EquipmentsAddPage(equipments));
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
