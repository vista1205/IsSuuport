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
    /// Логика взаимодействия для MonitorAddPage.xaml
    /// </summary>
    public partial class MonitorAddPage : Page
    {
        Monitors _monitor = new Monitors();
        public MonitorAddPage(Monitors monitor)
        {
            if (monitor != null)
            {
                _monitor = monitor;
            }
            InitializeComponent();
            DataContext = _monitor;
            CmbListComputer.ItemsSource = Helper.GetIsSupportContext().Computers.ToList();
            CmbListStatusDevice.ItemsSource = Helper.GetIsSupportContext().StatusDevice.ToList();
        }
        public MonitorAddPage()
        {
            InitializeComponent();
            DataContext = _monitor;
            CmbListComputer.ItemsSource = Helper.GetIsSupportContext().Computers.ToList();
            CmbListStatusDevice.ItemsSource = Helper.GetIsSupportContext().StatusDevice.ToList();
        }

        private void BtnAddMonitor_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbTitleMonitor.Text))
            {
                error.AppendLine("Необходимо указать название");
            }
            if (string.IsNullOrWhiteSpace(TbSerialNumberMonitor.Text))
            {
                error.AppendLine("Необходимо указать серийный номер");
            }
            if (string.IsNullOrWhiteSpace(TbInventoryNumberMonitor.Text))
            {
                error.AppendLine("Необходимо указать серийный номер");
            }
            if (CmbListStatusDevice.SelectedIndex == -1)
            {
                error.AppendLine("Необходимо указать статус монитора");
            }
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (_monitor.ID == 0)
            {
                if (CmbListComputer.SelectedIndex == -1)
                {
                    _monitor.ComputerID = null;
                }
                if (CmbListComputer.SelectedIndex != -1)
                {
                    _monitor.ComputerID = (CmbListComputer.SelectedItem as Computers).ID;
                }
                var monitorSN = Helper.GetIsSupportContext().Monitors.FirstOrDefault(x => x.SerialNumber == TbSerialNumberMonitor.Text);
                var monitorIN = Helper.GetIsSupportContext().Monitors.FirstOrDefault(x => x.SerialNumber == TbInventoryNumberMonitor.Text);
                if (monitorSN != null)
                {
                    error.AppendLine("Такой серийный номер уже существует!");
                }
                if (monitorIN != null)
                {
                    error.AppendLine("Такой инвентарный номер уже существует!");
                }
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString());
                    return;
                }
                _monitor.StatusDeviceID = (CmbListStatusDevice.SelectedItem as StatusDevice).ID;
                Helper.GetIsSupportContext().Monitors.Add(_monitor);
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
