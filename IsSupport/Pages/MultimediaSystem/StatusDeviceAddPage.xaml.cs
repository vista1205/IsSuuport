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
    /// Логика взаимодействия для StatusDeviceAddPage.xaml
    /// </summary>
    public partial class StatusDeviceAddPage : Page
    {
        StatusDevice statusDevice = new StatusDevice();
        public StatusDeviceAddPage(StatusDevice status)
        {
            InitializeComponent();
            if (status != null)
            {
                statusDevice = status;
            }
            DataContext = statusDevice;
        }
        public StatusDeviceAddPage()
        {
            InitializeComponent();
            DataContext = statusDevice;
        }

        private void BtnAddStatus_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error=new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbTitleStatus.Text))
            {
                error.AppendLine("Необходимо заполнить статус");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (statusDevice.ID == 0)
            {
                var statusEqui = Helper.GetIsSupportContext().StatusDevice.FirstOrDefault(x => x.Title == TbTitleStatus.Text);

                if (statusEqui != null)
                {
                    error.AppendLine("Такой статус уже существует!");
                }
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString());
                    return;
                }
                Helper.GetIsSupportContext().StatusDevice.Add(statusDevice);
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
