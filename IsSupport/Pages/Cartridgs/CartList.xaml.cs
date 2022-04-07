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
    /// Логика взаимодействия для CartList.xaml
    /// </summary>
    public partial class CartList : Page
    {
        List<Kartridjs> kart = new List<Kartridjs>();
        int kartstatus;
        public CartList()
        {
            InitializeComponent();
            CmbPrintFilter.ItemsSource = Helper.GetIsSupportContext().Printers.ToList();
            kart=Helper.GetIsSupportContext().Kartridjs.ToList();
            DGridCartridgeList.ItemsSource = kart.Where(x => x.StatusID == 1).ToList();
        }

        private void ListCartHouseMenu_Click(object sender, RoutedEventArgs e)
        {
            DGridCartridgeList.ItemsSource = kart.Where(x => x.StatusID == 1).ToList();
            kartstatus = 1;
        }

        private void ListCartIssueMenu_Click(object sender, RoutedEventArgs e)
        {
            DGridCartridgeList.ItemsSource = kart.Where(x => x.StatusID == 2).ToList();
            kartstatus = 2;
        }

        private void ListCartWaitingMenu_Click(object sender, RoutedEventArgs e)
        {
            DGridCartridgeList.ItemsSource = kart.Where(x => x.StatusID == 3).ToList();
            kartstatus = 3;
        }

        private void ListCartКefuelMenu_Click(object sender, RoutedEventArgs e)
        {
            DGridCartridgeList.ItemsSource = kart.Where(x => x.StatusID == 4).ToList();
            kartstatus = 4;
        }

        private void BtnAddCartridge_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddKartridgPage());
        }

        private void CmbPrintFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (CmbPrintFilter.SelectedItem as Printers).ID;
            DGridCartridgeList.ItemsSource=kart.Where(x=>x.PrinterID==item&&x.StatusID==kartstatus).ToList();
        }

        private void SearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            var filter=kart.Where(x=>x.NumberOfKartridj.ToUpperInvariant().Contains(SearchBox.Text.ToUpperInvariant()) && x.StatusID == kartstatus);
            DGridCartridgeList.ItemsSource = filter;
        }
    }
}
