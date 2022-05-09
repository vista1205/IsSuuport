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
    /// Логика взаимодействия для MouseListPage.xaml
    /// </summary>
    public partial class MouseListPage : Page
    {
        List<Mouse> mouse = new List<Mouse>();
        public MouseListPage()
        {
            InitializeComponent();
            mouse = Helper.GetIsSupportContext().Mouse.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            DgrListMouse.ItemsSource = Helper.GetIsSupportContext().Mouse.ToList();
        }

        private void CmbListStatusDevice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var statusMouse = (CmbListStatusDevice.SelectedItem as StatusDevice).ID;
            DgrListMouse.ItemsSource = mouse.Where(x => x.StatusDeviceID == statusMouse);
        }

        private void BtnAddMouse_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MouseAddPage());
        }

        private void BtnEditMouse_Click(object sender, RoutedEventArgs e)
        {
            if(DgrListMouse.SelectedItem is Mouse mouse)
            {
                NavigationService.Navigate(new MouseAddPage(mouse));
            }
        }

        private void BtnCancelMouse_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SearchBoxTitle_KeyUp(object sender, KeyEventArgs e)
        {
            var filter = mouse.Where(x => x.SerialNumber.ToUpperInvariant().Contains(SearchBoxTitle.Text.ToUpperInvariant()));
            DgrListMouse.ItemsSource = filter;
        }
    }
}
