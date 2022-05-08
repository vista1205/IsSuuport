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
    /// Логика взаимодействия для RoomListPage.xaml
    /// </summary>
    public partial class RoomListPage : Page
    {
        public RoomListPage()
        {
            InitializeComponent();
        }

        private void TbSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            DgrRoomsList.ItemsSource=Helper.GetIsSupportContext().Rooms.Where(x=>x.Title.ToUpperInvariant().Contains(TbSearchBox.Text.ToUpperInvariant())).ToList();
        }

        private void BtnAddRoom_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RoomAddPage());
        }

        private void BtnEditRoom_Click(object sender, RoutedEventArgs e)
        {
            if(DgrRoomsList.SelectedItem is Rooms room)
            {
                NavigationService.Navigate(new RoomAddPage(room));
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x=>x.Reload());
                DgrRoomsList.ItemsSource = Helper.GetIsSupportContext().Rooms.ToList();
            }
        }
    }
}
