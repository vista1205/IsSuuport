using IsSupport.Pages;
using IsSupport.Pages.Cartridgs;
using IsSupport.Pages.MultimediaSystem;
using IsSupport.Pages.Room;
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

        private void ListOrdersMenu_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new OrdersPage();
        }

        private void AddOrdersPageMenu_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new AddOrdersPage();
        }

        private void ListCartridgeMenu_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new CartList();
        }

        private void AddKartridg_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new AddKartridgPage();
        }

        private void CartridgIssue_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new CartReceivingAndIssuing();
        }

        private void CartridgReceving_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new CartridgRecevingPage();
        }

        private void CartridgeRefil_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new CartridgRecevingPage(3);
        }

        private void PrintersAdd_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new AddPrintersPage();
        }

        private void StatusCartridgs_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new StatusKartridgsPage();
        }

        private void AddStatusCartridgs_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new AddStatusCartridgs(null);
        }

        private void OSList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new OSListPage();
        }

        private void AddNewOS_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new OSAddPage();
        }

        private void SystemUnitsList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new SystemUnitsListPage();
        }

        private void TypeComponentsList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new TypeComponentListPage();
        }

        private void TypeComponentAdd_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new TypeComponentAddPage();
        }

        private void ComponentList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ComponentsListPage();
        }

        private void ComponentAdd_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new ComponetAddPage();
        }

        private void StatusDeviceList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new StatusDeviceListPage();
        }

        private void StatusDeviceAdd_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new StatusDeviceAddPage();
        }

        private void KeyboardsList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new KeyboardsListPage();
        }

        private void KeyboardAdd_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new KeyboardsAddPage();
        }

        private void MouseList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new MouseListPage();
        }

        private void MouseAdd_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new MouseAddPage();
        }

        private void MonitorsList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new MonitorsListPage();
        }

        private void AddMonitor_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new MonitorAddPage();
        }

        private void TypesEquipmentList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new TypesEquipmentListPage();
        }

        private void TypesEquipmentAdd_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new TypeComponentAddPage();
        }

        private void EquipmentsList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content= new EquipmentsListPage();
        }

        private void EquipmentsAdd_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new EquipmentsAddPage();
        }

        private void RoomsList_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content=new RoomListPage();
        }

        private void RoomAdd_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new RoomAddPage();
        }
    }
}
