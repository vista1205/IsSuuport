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
    /// Логика взаимодействия для MultimediaSystemsListPage.xaml
    /// </summary>
    public partial class MultimediaSystemsListPage : Page
    {
        List<MultimediaSystems> multimedias = new List<MultimediaSystems>();
        public MultimediaSystemsListPage()
        {
            InitializeComponent();
            multimedias=Helper.GetIsSupportContext().MultimediaSystems.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DgrMultimediaSystemssList.ItemsSource = Helper.GetIsSupportContext().MultimediaSystems.ToList();
            }
        }

        private void BtnAddMultimediaSystems_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MultimediaSystemsAddPage());
        }

        private void BtnEditMultimediaSystems_Click(object sender, RoutedEventArgs e)
        {
            if(DgrMultimediaSystemssList.SelectedItem is MultimediaSystems multimediaSystems)
            {
                NavigationService.Navigate(new MultimediaSystemsAddPage(multimediaSystems));
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void TbSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            var filter = multimedias.Where(x => x.Title.ToUpperInvariant().Contains(TbSearchBox.Text.ToUpperInvariant()));
            DgrMultimediaSystemssList.ItemsSource = filter;
        }
    }
}
