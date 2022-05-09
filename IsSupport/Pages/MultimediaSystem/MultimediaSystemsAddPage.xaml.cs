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
    /// Логика взаимодействия для MultimediaSystemsAddPage.xaml
    /// </summary>
    public partial class MultimediaSystemsAddPage : Page
    {
        MultimediaSystems _multimediaSystems=new MultimediaSystems();
        public MultimediaSystemsAddPage(MultimediaSystems multimediaSystem)
        {
            InitializeComponent();
            if (multimediaSystem != null)
            {
                _multimediaSystems = multimediaSystem;
            }
            CmbRoomsList.ItemsSource = Helper.GetIsSupportContext().Rooms.ToList();
            DataContext = _multimediaSystems;
        }
        public MultimediaSystemsAddPage()
        {
            InitializeComponent();
            CmbRoomsList.ItemsSource = Helper.GetIsSupportContext().Rooms.ToList();
            DataContext = _multimediaSystems;
        }

        private void BtnAddSystem_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbTitleSystem.Text))
            {
                error.AppendLine("Необходимо ввести название системы");
            }
            if (CmbRoomsList.SelectedItem == null)
            {
                error.AppendLine("Необходимо выбрать кабинет");
            }
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (_multimediaSystems.ID == 0)
            {
                var multSystem = Helper.GetIsSupportContext().MultimediaSystems.FirstOrDefault(x => x.Title == TbTitleSystem.Text);
                if (multSystem != null)
                {
                    error.AppendLine("Система с таким наименование уже существует");
                }
                _multimediaSystems.RoomID = (CmbRoomsList.SelectedItem as Rooms).ID;
                Helper.GetIsSupportContext().MultimediaSystems.Add(_multimediaSystems);
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
