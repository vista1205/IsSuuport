using IsSupport.Pages;
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

namespace IsSupport
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserSecret userSecret = new UserSecret();

        Helper helper = new Helper();
        public MainWindow()
        {
            InitializeComponent();
            Application.Current.ShutdownMode = ShutdownMode.OnLastWindowClose;
            MyFrame.Content = new OrdersPage();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            userSecret.DeleteUserSecret();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            helper.CloseParentWondow();
            addEmployee.Show();
            userSecret.DeleteUserSecret();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            helper.CloseParentWondow();
        }
    }
}
