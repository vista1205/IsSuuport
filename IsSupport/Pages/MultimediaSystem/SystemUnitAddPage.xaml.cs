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
    /// Логика взаимодействия для SystemUnitAddPage.xaml
    /// </summary>
    public partial class SystemUnitAddPage : Page
    {
        SystemUnits _systemUnits = new SystemUnits();
        public SystemUnitAddPage()
        {
            InitializeComponent();
            CmbListComponents.ItemsSource = Helper.GetIsSupportContext().Components.ToList();
            CmbListComputers.ItemsSource = Helper.GetIsSupportContext().Computers.ToList();
            CmbListStatusDevice.ItemsSource=Helper.GetIsSupportContext().StatusDevice.ToList();
            DataContext = _systemUnits;
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
               // DgrListComponents.ItemsSource = _systemUnitComponents.ToList();
            }
        }

        List<SystemUnitComponents> _systemUnitComponents = new List<SystemUnitComponents>();
        private void BtnAddComponent_Click(object sender, RoutedEventArgs e)
        {
            var selectedComponent = CmbListComponents.SelectedItem as Components;
            SystemUnitComponents systemUnitComponents = new SystemUnitComponents()
            {
                Count = Int32.Parse(TbCountComponents.Text),
                ComponentID = selectedComponent.ID,
            };
            _systemUnitComponents.Add(systemUnitComponents);
            //DgrListComponents.ItemsSource=_systemUnitComponents.ToList();
        }

        private void BtnAddSystemUnit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
