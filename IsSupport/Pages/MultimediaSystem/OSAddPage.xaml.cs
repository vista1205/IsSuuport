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

namespace IsSupport.Pages.MultimediaSystems
{
    /// <summary>
    /// Логика взаимодействия для OSAddPage.xaml
    /// </summary>
    public partial class OSAddPage : Page
    {
        OS os = new OS();
        public OSAddPage()
        {
            InitializeComponent();
            DataContext = os;
        }

        private void BtnAddOS_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbNameOS.Text))
            {
                error.AppendLine("Необходимо указать название новой Операционной системы!");
            }
            if (string.IsNullOrWhiteSpace(TbByteOS.Text))
            {
                error.AppendLine("Необходимо указать разрядность Операционной системы!");
            }
            var targetOS=Helper.GetIsSupportContext().OS.FirstOrDefault(x=>x.Title == TbNameOS.Text && x.BitDepth == TbByteOS.Text);
            if (targetOS != null)
            {
                error.AppendLine("Необходимо указать уникальные значения!");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            Helper.GetIsSupportContext().OS.Add(os);
            try
            {
                Helper.GetIsSupportContext().SaveChanges();
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }

        private void BtnCancelOS_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
