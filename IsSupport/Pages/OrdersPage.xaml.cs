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
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(entry =>entry.Reload());
                DGridOrders.ItemsSource = Helper.GetIsSupportContext().Orders.ToList();
            }
        }

        private void BtnFilFull_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddOrders_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOrdersPage());
        }
    }
}
