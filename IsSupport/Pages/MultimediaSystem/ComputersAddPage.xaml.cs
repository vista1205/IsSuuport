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
    /// Логика взаимодействия для ComputersAddPage.xaml
    /// </summary>
    public partial class ComputersAddPage : Page
    {
        List<OS> _os = new List<OS>();
        List<MultimediaSystems> _multimediaSystems = new List<MultimediaSystems>();
        Computers _comp = new Computers();
        public ComputersAddPage()
        {
            InitializeComponent();
            DataContext = _comp;
            _os = Helper.GetIsSupportContext().OS.ToList();
            _multimediaSystems=Helper.GetIsSupportContext().MultimediaSystems.ToList();
            CmbOSList.ItemsSource = _os;
            CmbMultimediaSystemsList.ItemsSource = _multimediaSystems;
        }
        public ComputersAddPage(Computers comp)
        {
            InitializeComponent();
            if (comp != null)
            {
                _comp = comp;
            }
            DataContext = _comp;
            _os = Helper.GetIsSupportContext().OS.ToList();
            _multimediaSystems = Helper.GetIsSupportContext().MultimediaSystems.ToList();
            CmbOSList.ItemsSource = _os;
            CmbMultimediaSystemsList.ItemsSource = _multimediaSystems;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            int selectedOsId = (CmbOSList.SelectedItem as OS).ID;
            int selectedMultiId = (CmbMultimediaSystemsList.SelectedItem as MultimediaSystems).ID;
            if(_comp.ID != 0)
            {
                _comp.OSID = selectedOsId;
                _comp.MultimediaSystemID = selectedMultiId;
            }
            if (_comp.ID == 0)
            {
                _comp.OSID = selectedOsId;
                _comp.MultimediaSystemID = selectedMultiId;
                Helper.GetIsSupportContext().Computers.Add(_comp);
            }
            try
            {
                Helper.GetIsSupportContext().SaveChanges();
                MessageBox.Show("Данные были сохранены", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
