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
    /// Логика взаимодействия для TypeComponentListPage.xaml
    /// </summary>
    public partial class TypeComponentListPage : Page
    {
        List<TypeComponent> typeComponents = new List<TypeComponent>();
        public TypeComponentListPage()
        {
            InitializeComponent();
            typeComponents=Helper.GetIsSupportContext().TypeComponent.ToList();
            DgrListTypeComponents.ItemsSource = typeComponents;
        }

        private void BtnAddTypeComponent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TypeComponentAddPage());
        }

        private void BtnEditTypeComponent_Click(object sender, RoutedEventArgs e)
        {
            if(DgrListTypeComponents.SelectedItem is TypeComponent component)
            {
                NavigationService.Navigate(new TypeComponentAddPage(component));
            }
        }

        private void BtnCancelTypeComponent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SearchBoxTitle_KeyUp(object sender, KeyEventArgs e)
        {
            DgrListTypeComponents.ItemsSource=typeComponents.Where(x=>x.Title.ToUpperInvariant().Contains(SearchBoxTitle.Text.ToUpperInvariant())).ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DgrListTypeComponents.ItemsSource = Helper.GetIsSupportContext().TypeComponent.ToList();
            }
        }
    }
}
