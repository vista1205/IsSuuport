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
    /// Логика взаимодействия для OSListPage.xaml
    /// </summary>
    public partial class OSListPage : Page
    {
        public OSListPage()
        {
            InitializeComponent();
        }

        private void BtnAddOS_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OSAddPage());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x=>x.Reload());
                DgrListOS.ItemsSource = Helper.GetIsSupportContext().OS.ToList();
            }
        }
    }
}
