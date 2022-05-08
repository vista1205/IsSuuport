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
    /// Логика взаимодействия для EquipmentsAddPage.xaml
    /// </summary>
    public partial class EquipmentsAddPage : Page
    {
        Equipments _equipments = new Equipments();
        public EquipmentsAddPage(Equipments equipments)
        {
            InitializeComponent();
            if(equipments != null)
            {
                _equipments = equipments;
            }
            DataContext = _equipments;
            CmbMultimediaSystemsList.ItemsSource = Helper.GetIsSupportContext().MultimediaSystems.ToList();
            CmbStatusDeviceList.ItemsSource = Helper.GetIsSupportContext().StatusDevice.ToList();
            CmbTypeEquipmentList.ItemsSource = Helper.GetIsSupportContext().TypesEquipment.ToList();
        }
        public EquipmentsAddPage()
        {
            InitializeComponent();
            DataContext = _equipments;
            CmbMultimediaSystemsList.ItemsSource = Helper.GetIsSupportContext().MultimediaSystems.ToList();
            CmbStatusDeviceList.ItemsSource=Helper.GetIsSupportContext().StatusDevice.ToList();
            CmbTypeEquipmentList.ItemsSource=Helper.GetIsSupportContext().TypesEquipment.ToList();
        }

        private void BtnAddEquipments_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error=new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbTitleEquipments.Text))
            {
                error.AppendLine("Необходимо указать название");
            }
            if (string.IsNullOrWhiteSpace(TbSerialNumberEquipments.Text))
            {
                error.AppendLine("Необоходимо указать серийный номер");
            }
            if(CmbStatusDeviceList.SelectedIndex == -1)
            {
                error.AppendLine("Необходимо указать статус устройства");
            }
            if(CmbTypeEquipmentList.SelectedIndex == -1)
            {
                error.AppendLine("Необходимо указать тип устройства");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (_equipments.ID == 0)
            {
                var serialNumber = Helper.GetIsSupportContext().Equipments.FirstOrDefault(x => x.SerialNumber == TbSerialNumberEquipments.Text);
                if(serialNumber != null)
                {
                    error.AppendLine("Необходимо указать уникальный серийный номер оборудования");
                }
                if(CmbMultimediaSystemsList.SelectedIndex == -1)
                {
                    _equipments.MultimediaSystemID = null;
                }
                if (CmbMultimediaSystemsList.SelectedIndex != -1)
                {
                    _equipments.MultimediaSystemID = (CmbMultimediaSystemsList.SelectedItem as MultimediaSystems).ID;
                }
                _equipments.StatusDeviceID = (CmbStatusDeviceList.SelectedItem as StatusDevice).ID;
                _equipments.TypeEquipmentID = (CmbTypeEquipmentList.SelectedItem as TypesEquipment).ID;
                Helper.GetIsSupportContext().Equipments.Add(_equipments);
            }
            try
            {
                Helper.GetIsSupportContext().SaveChanges();
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
