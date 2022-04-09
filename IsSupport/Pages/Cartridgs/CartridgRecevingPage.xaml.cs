using static IsSupport.Views.VMKartridgs;
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
    /// Логика взаимодействия для CartridgRecevingPage.xaml
    /// </summary>
    public partial class CartridgRecevingPage : Page
    {
        public VMKartridjs vMKartridjs { get; set; } = new VMKartridjs();
        private List<Kartridjs> _kartridjs = new List<Kartridjs>();
        public CartridgRecevingPage( int a)
        {
            InitializeComponent();
            DataContext = vMKartridjs;
            _kartridjs = Helper.GetIsSupportContext().Kartridjs.Where(x => x.StatusID == a).ToList();
            CmbRecevingCartridg.ItemsSource = _kartridjs;
            BtnRecevingKartridg.Content = "Отправить на заправку";
            TblAbout.Text = "Выберите картридж для того, чтобы отправиь на заправку";
        }
        public CartridgRecevingPage()
        {
            InitializeComponent();
            DataContext = vMKartridjs;
            _kartridjs = Helper.GetIsSupportContext().Kartridjs.Where(x => x.StatusID == 2).ToList();
            CmbRecevingCartridg.ItemsSource = _kartridjs;
        }

        //private void CmbRecevingCartridg_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var tb = (TextBox)e.OriginalSource;
        //    if (tb.SelectionStart == 0)
        //    {
        //        CmbRecevingCartridg.SelectedItem = null;
        //    }
        //    if (tb.SelectionStart == 0 && CmbRecevingCartridg.SelectedItem == null)
        //    {
        //        CmbRecevingCartridg.IsDropDownOpen = false;
        //    }
        //    CmbRecevingCartridg.IsDropDownOpen = true;
        //    if (string.IsNullOrEmpty(CmbRecevingCartridg.Text))
        //    {
        //        CmbRecevingCartridg.ItemsSource = _kartridjs;
        //    }
        //    CmbRecevingCartridg.ItemsSource = _kartridjs.Where((item) => { return item.Title.Contains(CmbRecevingCartridg.Text); });
        //}

        private void BtnRecevingKartridg_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error= new StringBuilder();
            if (vMKartridjs.Kartridjs.NumberOfKartridj == null)
            {
                error.AppendLine("Необходимо выбрать картридж!");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            int statusCartridgs = (CmbRecevingCartridg.SelectedItem as Kartridjs).StatusID;
            if (statusCartridgs == 2)
            {
                vMKartridjs.Kartridjs.StatusID = 3;
                vMKartridjs.Kartridjs.RoomID = 1;
            }
            if(statusCartridgs == 3)
            {
                vMKartridjs.Kartridjs.StatusID = 4;
                vMKartridjs.Kartridjs.RoomID = 1;
            }
            try
            {
                Helper.GetIsSupportContext().SaveChanges();
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return ;
            }
        }

        private void BtnRecevingBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
