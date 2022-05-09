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

namespace IsSupport.Pages.Room
{
    /// <summary>
    /// Логика взаимодействия для RoomAddPage.xaml
    /// </summary>
    public partial class RoomAddPage : Page
    {
        Rooms _rooms = new Rooms();
        public RoomAddPage(Rooms rooms)
        {
            InitializeComponent();
            if (rooms != null)
            {
                _rooms = rooms;
            }
            DataContext = _rooms;
        }
        public RoomAddPage()
        {
            InitializeComponent();
            DataContext = _rooms;
        }

        private void BtnAddRoom_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error=new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbTitleRoom.Text))
            {
                error.AppendLine("Необходимо указать номер кабинета");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (_rooms.ID == 0)
            {
                var roomID=Helper.GetIsSupportContext().Rooms.FirstOrDefault(x=>x.Title==TbTitleRoom.Text);
                if(roomID != null)
                {
                    error.AppendLine("Такой кабинет уже существует");
                }
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString());
                    return;
                }
                Helper.GetIsSupportContext().Rooms.Add(_rooms);
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
