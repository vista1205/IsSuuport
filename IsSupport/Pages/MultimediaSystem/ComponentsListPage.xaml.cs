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
    /// Логика взаимодействия для ComponentsListPage.xaml
    /// </summary>
    public partial class ComponentsListPage : Page
    {
        List<Components> components = new List<Components>();
        public ComponentsListPage()
        {
            InitializeComponent();
            CmbListTypeComponent.ItemsSource = Helper.GetIsSupportContext().TypeComponent.ToList();
            components=Helper.GetIsSupportContext().Components.ToList();
            DgrListComponents.ItemsSource = components;
        }

        private void SearchBoxTitle_KeyUp(object sender, KeyEventArgs e)
        {
            DgrListComponents.ItemsSource=components.Where(x=>x.Title.ToUpperInvariant().Contains(SearchBoxTitle.Text.ToUpperInvariant())).ToList();
        }

        private void BtnAddComponent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComponetAddPage());
        }

        private void BtnCancelComponent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CmbListTypeComponent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var typeID = (CmbListTypeComponent.SelectedItem as TypeComponent).ID;
            DgrListComponents.ItemsSource=components.Where(x=>x.TypeComponentID==typeID).ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DgrListComponents.ItemsSource = Helper.GetIsSupportContext().Components.ToList();
            }
        }

        private void BtnEditComponent_Click(object sender, RoutedEventArgs e)
        {
            if (DgrListComponents.SelectedItem is Components comp)
            {
                NavigationService.Navigate(new ComponetAddPage(comp));
            }
        }
    }
}
