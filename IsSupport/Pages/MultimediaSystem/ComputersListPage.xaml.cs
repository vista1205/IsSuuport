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
    /// Логика взаимодействия для ComputersListPage.xaml
    /// </summary>
    public partial class ComputersListPage : Page
    {
        private List<Computers> _computers = new List<Computers>();
        public ComputersListPage()
        {
            InitializeComponent();
            _computers = Helper.GetIsSupportContext().Computers.ToList();
            DgrListComponents.ItemsSource= _computers;
        }

        private void BtnAddComponent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComputersAddPage());
        }

        private void BtnEditComponent_Click(object sender, RoutedEventArgs e)
        {
            if(DgrListComponents.SelectedItem is Computers comp)
            {
                NavigationService.Navigate(new ComputersAddPage(comp));
            }
        }

        private void BtnCancelComponent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SearchBoxTitle_KeyUp(object sender, KeyEventArgs e)
        {
            _computers = Helper.GetIsSupportContext().Computers.Where(x => x.MultimediaSystemID == int.Parse(SearchBoxTitle.Text)).ToList();
            DgrListComponents.ItemsSource = _computers;
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DgrListComponents.ItemsSource = Helper.GetIsSupportContext().Computers.ToList();
            }
        }
    }
}
