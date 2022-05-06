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
    /// Логика взаимодействия для StatusKartridgsPage.xaml
    /// </summary>
    public partial class StatusKartridgsPage : Page
    {
        public StatusKartridgsPage()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DgrStatusCartridgList.ItemsSource = Helper.GetIsSupportContext().StatusKartridj.ToList();
            }
        }

        private void AddStatusCartridg_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new AddStatusCartridgs(null));
        }

        private void EditStatusCartridg_Click(object sender, RoutedEventArgs e)
        {
            if(DgrStatusCartridgList.SelectedItem is StatusKartridj statusKartridj)
            {
                NavigationService.Navigate(new AddStatusCartridgs(statusKartridj));
            }
        }

        private void StatusCartridgBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
