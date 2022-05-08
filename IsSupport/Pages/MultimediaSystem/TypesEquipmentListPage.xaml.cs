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
    /// Логика взаимодействия для TypesEquipmentListPage.xaml
    /// </summary>
    public partial class TypesEquipmentListPage : Page
    {
        public TypesEquipmentListPage()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DgrTypesEquipmentList.ItemsSource=Helper.GetIsSupportContext().TypesEquipment.ToList();
            }
        }

        private void BtnAddTypesEquipment_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TypesEquipmentAddPage());
        }

        private void BtnEditTypesEquipment_Click(object sender, RoutedEventArgs e)
        {
            if(DgrTypesEquipmentList.SelectedItem is TypesEquipment typesEquipment)
            {
                NavigationService.Navigate(new TypesEquipmentAddPage(typesEquipment));
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
