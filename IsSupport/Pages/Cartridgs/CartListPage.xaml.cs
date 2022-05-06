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

        private void KartIssue_Click(object sender, RoutedEventArgs e)
        {
            int index = (DGridCartridgeList.SelectedItem as Kartridjs).StatusID;
            switch (index)
            {
                case 1:
                    NavigationService.Navigate(new CartReceivingAndIssuing((sender as Button).DataContext as Kartridjs));
                    break;
                case 2:
                    {
                        int kartridgID = (DGridCartridgeList.SelectedItem as Kartridjs).ID;
                        var selectKartridg = kart.Where(x => x.ID == kartridgID).FirstOrDefault();
                        selectKartridg.StatusID = 3;
                        selectKartridg.RoomID = 1;
                        Helper.GetIsSupportContext().SaveChanges();
                        Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                        DGridCartridgeList.ItemsSource = kart.Where(x => x.StatusID == 2).ToList();
                    }
                    break;
                case 3:
                    {
                        int kartridgID = (DGridCartridgeList.SelectedItem as Kartridjs).ID;
                        var selectKartridg = kart.Where(x => x.ID == kartridgID).FirstOrDefault();
                        selectKartridg.StatusID = 4;
                        selectKartridg.RoomID = 1;
                        Helper.GetIsSupportContext().SaveChanges();
                        Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                        DGridCartridgeList.ItemsSource=kart.Where(x=>x.StatusID==3).ToList();
                    }                    
                    break;
                case 4:
                    {
                        int kartridgID = (DGridCartridgeList.SelectedItem as Kartridjs).ID;
                        var selectKartridg = kart.Where(x => x.ID == kartridgID).FirstOrDefault();
                        selectKartridg.StatusID = 1;
                        selectKartridg.RoomID = 1;
                        Helper.GetIsSupportContext().SaveChanges();
                        Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                        DGridCartridgeList.ItemsSource = kart.Where(x => x.StatusID == 4).ToList();
                    }                    
                    break;
            }
        }

        private void BtnRemoveCartridg_Click(object sender, RoutedEventArgs e)
        {
            var cartridgRemove = DGridCartridgeList.SelectedItems.Cast<Kartridjs>().ToList();
            switch (kartstatus)
            {
                case 2:
                    foreach (Kartridjs kartridjs in cartridgRemove)
                    {
                        kartridjs.StatusID = 3;
                        kartridjs.RoomID = 1;
                    }
                    Helper.GetIsSupportContext().SaveChanges();
                    Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                    DGridCartridgeList.ItemsSource = kart.Where(x => x.StatusID == 2).ToList();
                    break;
                case 3:
                    foreach(Kartridjs kartridjs in cartridgRemove)
                    {
                        kartridjs.StatusID = 4;
                        kartridjs.RoomID = 1;
                    }
                    Helper.GetIsSupportContext().SaveChanges();
                    Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                    DGridCartridgeList.ItemsSource = kart.Where(x => x.StatusID == 3).ToList();
                    break;
                case 4:
                    foreach (Kartridjs kartridjs in cartridgRemove)
                    {
                        kartridjs.StatusID = 1;
                        kartridjs.RoomID = 1;
                    }
                    Helper.GetIsSupportContext().SaveChanges();
                    Helper.GetIsSupportContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                    DGridCartridgeList.ItemsSource = kart.Where(x => x.StatusID == 4).ToList();
                    break;
            }
        }

        private void DGridCartridgeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BtnRemoveCartridg.Visibility = DGridCartridgeList.SelectedItems.Count > 1 && (kartstatus == 3 || kartstatus == 4 || kartstatus == 2) ? Visibility.Visible : Visibility.Collapsed;
            switch (kartstatus)
            {
                case 2:
                    BtnRemoveCartridg.Content = "Принять";
                    break;
                case 3:
                    BtnRemoveCartridg.Content = "Отправить на заправку";
                    break;
                case 4:
                    BtnRemoveCartridg.Content = "Принять с заправки";
                    break;
            }
        }
    }
}
