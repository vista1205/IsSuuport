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

namespace IsSupport.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddOrdersPage.xaml
    /// </summary>
    public partial class AddOrdersPage : Page
    {
        private Orders _contextOrders = new Orders();
        UserSecret _secret = new UserSecret();
        private List<Rooms> _rooms = new List<Rooms>();
        public AddOrdersPage()
        {
            InitializeComponent();
            DataContext = _contextOrders;
            _rooms = Helper.GetIsSupportContext().Rooms.ToList();
            ComboRooms.ItemsSource = _rooms;
        }

        private void BtnAddOrders_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_contextOrders.Description))
            {
                erros.AppendLine("Вы не указали проблему!");
            }
            if (_contextOrders.Rooms == null)
            {
                erros.AppendLine("Укажите кабинет!");
            }
            if(erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
                return;
            }
            if (_contextOrders.ID == 0)
            {
                _contextOrders.EmployeeID = _secret.ReturnUserID();
                _contextOrders.DateCreatet = DateTime.Now;
                _contextOrders.StatusOrderID = 1;
                Helper.GetIsSupportContext().Orders.Add(_contextOrders);
                try
                {
                    Helper.GetIsSupportContext().SaveChanges();
                    NavigationService.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void ComboRooms_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)e.OriginalSource;
            if (tb.SelectionStart != 0)
            {
                ComboRooms.SelectedItem = null;
            }
            if(tb.SelectionStart==0 && ComboRooms.SelectedItem == null)
            {
                ComboRooms.IsDropDownOpen = false;
            }
            ComboRooms.IsDropDownOpen=true;
            if (string.IsNullOrEmpty(ComboRooms.Text))
            {
                ComboRooms.ItemsSource = _rooms;
            }
            ComboRooms.ItemsSource = _rooms.Where((item) => { return item.Title.Contains(ComboRooms.Text); });
        }
    }
}
