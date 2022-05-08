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
    /// Логика взаимодействия для KeyboardsAddPage.xaml
    /// </summary>
    public partial class KeyboardsAddPage : Page
    {
        Keyboards _keyboards = new Keyboards();
        public KeyboardsAddPage(Keyboards keyboards)
        {
            InitializeComponent();
            if(keyboards != null)
            {
                _keyboards = keyboards;
            }
            DataContext = _keyboards;
            CmbListComputer.ItemsSource = Helper.GetIsSupportContext().Computers.ToList();
            CmbListStatusDevice.ItemsSource = Helper.GetIsSupportContext().StatusDevice.ToList();
        }
        public KeyboardsAddPage()
        {
            InitializeComponent();
            DataContext = _keyboards;
            CmbListComputer.ItemsSource = Helper.GetIsSupportContext().Computers.ToList();
            CmbListStatusDevice.ItemsSource = Helper.GetIsSupportContext().StatusDevice.ToList();
        }

        private void BtnAddKeyboards_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error=new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbTitleKeyboard.Text))
            {
                error.AppendLine("Необходимо указать название");
            }
            if (string.IsNullOrWhiteSpace(TbSerialNumberKeyboard.Text))
            {
                error.AppendLine("Необходимо указать серийный номер");
            }
            if (CmbListStatusDevice.SelectedIndex == -1)
            {
                error.AppendLine("Необходимо указать статус клавиатуры");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (_keyboards.ID == 0)
            {                
                if (CmbListComputer.SelectedIndex == -1)
                {
                    _keyboards.ComputerID = null;
                }
                if (CmbListComputer.SelectedIndex != -1)
                {
                    _keyboards.ComputerID = (CmbListComputer.SelectedItem as Computers).ID;
                }
                var keyboardSN = Helper.GetIsSupportContext().Keyboards.FirstOrDefault(x => x.SerialNumber == TbSerialNumberKeyboard.Text);
                if (keyboardSN != null)
                {
                    error.AppendLine("Такой серийный номер уже существует!");
                }
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString());
                    return;
                }
                _keyboards.StatusDeviceID = (CmbListStatusDevice.SelectedItem as StatusDevice).ID;
                Helper.GetIsSupportContext().Keyboards.Add(_keyboards);
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
