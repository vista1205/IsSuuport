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
    /// Логика взаимодействия для AddStatusCartridgs.xaml
    /// </summary>
    public partial class AddStatusCartridgs : Page
    {
        private StatusKartridj _statusKartridj=new StatusKartridj();
        public AddStatusCartridgs(StatusKartridj statusKartridj)
        {
            InitializeComponent();
            if (statusKartridj != null)
            {
                _statusKartridj = statusKartridj;
            }
            DataContext = _statusKartridj;
        }

        private void SaveStatusCartridg_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error=new StringBuilder();
            if (string.IsNullOrWhiteSpace(TxbTitleStatusCartridg.Text))
            {
                error.AppendLine("Необходимо указать наименование статуса!");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (_statusKartridj.ID == 0)
            {
                Helper.GetIsSupportContext().StatusKartridj.Add(_statusKartridj);
            }
            try
            {
                Helper.GetIsSupportContext().SaveChanges();
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BackStatusCartridg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
