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
    /// Логика взаимодействия для MouseAddPage.xaml
    /// </summary>
    public partial class MouseAddPage : Page
    {
        Mouse _mouse=new Mouse();
        public MouseAddPage(Mouse mouse)
        {
            InitializeComponent();
            if (mouse != null)
            {
                _mouse = mouse;
            }
            DataContext = _mouse;
            CmbListComputer.ItemsSource = Helper.GetIsSupportContext().Computers.ToList();
            CmbListStatusDevice.ItemsSource = Helper.GetIsSupportContext().StatusDevice.ToList();
        }
        public MouseAddPage()
        {
            InitializeComponent();
            DataContext = _mouse;
            CmbListComputer.ItemsSource = Helper.GetIsSupportContext().Computers.ToList();
            CmbListStatusDevice.ItemsSource = Helper.GetIsSupportContext().StatusDevice.ToList();
        }

        private void BtnAddMouse_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbTitleMouse.Text))
            {
                error.AppendLine("Необходимо указать название");
            }
            if (string.IsNullOrWhiteSpace(TbSerialNumberMouse.Text))
            {
                error.AppendLine("Необходимо указать серийный номер");
            }
            if (CmbListStatusDevice.SelectedIndex == -1)
            {
                error.AppendLine("Необходимо указать статус клавиатуры");
            }
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (_mouse.ID == 0)
            {
                if (CmbListComputer.SelectedIndex == -1)
                {
                    _mouse.ComputerID = null;
                }
                if (CmbListComputer.SelectedIndex != -1)
                {
                    _mouse.ComputerID = (CmbListComputer.SelectedItem as Computers).ID;
                }
                var mouseSN = Helper.GetIsSupportContext().Mouse.FirstOrDefault(x => x.SerialNumber == TbSerialNumberMouse.Text);
                if (mouseSN != null)
                {
                    error.AppendLine("Такой серийный номер уже существует!");
                }
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString());
                    return;
                }
                _mouse.StatusDeviceID = (CmbListStatusDevice.SelectedItem as StatusDevice).ID;
                Helper.GetIsSupportContext().Mouse.Add(_mouse);
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
