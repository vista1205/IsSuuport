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
//using static IsSupport.Views.VMKartridgs;

namespace IsSupport.Pages.Cartridgs
{
    /// <summary>
    /// Логика взаимодействия для CartReceivingAndIssuing.xaml
    /// </summary>
    public partial class CartReceivingAndIssuing : Page
    {
        public class VMKartridjs
        {
            public Kartridjs Kartridjs { get; set; }
        }
        public VMKartridjs VmKartridgs { get; set; }=new VMKartridjs();
        private List<Rooms> _rooms = new List<Rooms>();
        private List<Kartridjs> _kartridjs = new List<Kartridjs>();

        public CartReceivingAndIssuing()
        {
            InitializeComponent();
            DataContext = VmKartridgs;
            _rooms = Helper.GetIsSupportContext().Rooms.ToList();
            _kartridjs = Helper.GetIsSupportContext().Kartridjs.Where(x => x.StatusID == 1).ToList();
            CmbRoomsCartridg.ItemsSource = _rooms;
            CmbCartridgIssue.ItemsSource = _kartridjs;
        }
        public CartReceivingAndIssuing(Kartridjs selectedKartridg)
        {
            InitializeComponent();
            if (selectedKartridg != null)
            {
                VmKartridgs = new VMKartridjs() { Kartridjs = selectedKartridg };
            }
            DataContext = VmKartridgs;
            _rooms = Helper.GetIsSupportContext().Rooms.ToList();
            _kartridjs = Helper.GetIsSupportContext().Kartridjs.Where(x=>x.StatusID==1).ToList();
            CmbRoomsCartridg.ItemsSource = _rooms;
            CmbCartridgIssue.ItemsSource = _kartridjs;
        }

        private void BtnKartridgIssue_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (VmKartridgs.Kartridjs.NumberOfKartridj == null)
            {
                error.AppendLine("Необходимо выбрать картридж!");
            }
            if (VmKartridgs.Kartridjs.Rooms == null)
            {
                error.AppendLine("Необходимо указать кабинет!");
            }
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            VmKartridgs.Kartridjs.StatusID = 2;
            try
            {
                Helper.GetIsSupportContext().SaveChanges();
                NavigationService.GoBack();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message.ToString()); }
        }

        private void BtnKartridgReturn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //private void CmbCartridgIssue_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var tb = (TextBox)e.OriginalSource;
        //    if (tb.SelectionStart == 0)
        //    {
        //        CmbCartridgIssue.SelectedItem = null;
        //    }
        //    if (tb.SelectionStart == 0 && CmbCartridgIssue.SelectedItem == null)
        //    {
        //        CmbCartridgIssue.IsDropDownOpen = false;
        //    }
        //    CmbCartridgIssue.IsDropDownOpen = true;
        //    if (string.IsNullOrEmpty(CmbCartridgIssue.Text))
        //    {
        //        CmbCartridgIssue.ItemsSource = _kartridjs;
        //    }
        //    CmbCartridgIssue.ItemsSource = _kartridjs.Where((item) => { return item.Title.Contains(CmbCartridgIssue.Text); });
        //}

        //private void CmbRoomsCartridg_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var tb = (TextBox)e.OriginalSource;
        //    if (tb.SelectionStart == 0)
        //    {
        //        CmbRoomsCartridg.SelectedItem = null;
        //    }
        //    if (tb.SelectionStart == 0 && CmbRoomsCartridg.SelectedItem == null)
        //    {
        //        CmbRoomsCartridg.IsDropDownOpen = false;
        //    }
        //    CmbRoomsCartridg.IsDropDownOpen = true;
        //    if (string.IsNullOrEmpty(CmbRoomsCartridg.Text))
        //    {
        //        CmbRoomsCartridg.ItemsSource = _kartridjs;
        //    }
        //    CmbRoomsCartridg.ItemsSource = _rooms.Where((item) => { return item.Title.Contains(CmbRoomsCartridg.Text); });
        //}
    }
}
