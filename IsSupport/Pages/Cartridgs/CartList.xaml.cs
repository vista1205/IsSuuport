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

namespace IsSupport.Pages.Cartridgs
{
    /// <summary>
    /// Логика взаимодействия для CartList.xaml
    /// </summary>
    public partial class CartList : Page
    {
        public CartList()
        {
            InitializeComponent();
            MyFrameCartList.Content = new CartridgePage();
        }

        private void ListCartHouseMenu_Click(object sender, RoutedEventArgs e)
        {
            MyFrameCartList.Content=new CartridgePage();
        }

        private void ListCartIssueMenu_Click(object sender, RoutedEventArgs e)
        {
            MyFrameCartList.Content = new CartridgeIssueListPage();
        }

        private void ListCartWaitingMenu_Click(object sender, RoutedEventArgs e)
        {
            MyFrameCartList.Content = new CartridgeWaitingListPage();
        }

        private void ListCartКefuelMenu_Click(object sender, RoutedEventArgs e)
        {
            MyFrameCartList.Content = new CartridgeRefuelListPage();
        }
    }
}
