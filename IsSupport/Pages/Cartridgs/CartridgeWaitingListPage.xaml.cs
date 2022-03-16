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
    /// Логика взаимодействия для CartridgeWaitingListPage.xaml
    /// </summary>
    public partial class CartridgeWaitingListPage : Page
    {
        public CartridgeWaitingListPage()
        {
            InitializeComponent();
            CmbPrintFilter.ItemsSource = Helper.GetIsSupportContext().Printers.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(entry => entry.Reload());
                DGridCartridgeList.ItemsSource = Helper.GetIsSupportContext().Kartridjs.Where(x => x.StatusID == 3).ToList();
            }
        }
        private void CmbPrintFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (CmbPrintFilter.SelectedItem as Printers).ID;
            DGridCartridgeList.ItemsSource = Helper.GetIsSupportContext().Kartridjs.Where(x => x.StatusID == 3 && x.PrinterID == item).ToList();
        }
    }
}
