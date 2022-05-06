using Microsoft.Win32;
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
    /// Логика взаимодействия для AddPrintersPage.xaml
    /// </summary>
    public partial class AddPrintersPage : Page
    {
        private Printers _contextPrinters=new Printers();
        string pathImage = null;
        string nameImage = null;
        public AddPrintersPage()
        {
            InitializeComponent();
            DataContext = _contextPrinters;
        }

        private void BtnAddImagePrinters_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory + "\\images\\Printers\\",
                Filter = "Image files (*.BMP, *.JPG, *.JPEG)|*.bmp; *.jpg;*.jpeg",
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == true)
            {
                nameImage = ofd.SafeFileName;
                pathImage = ofd.FileName.Replace(nameImage, "");
                PreviewImage.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }

        private void BtnAddPrinters_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            StringBuilder error=new StringBuilder();
            if (string.IsNullOrWhiteSpace(TxbAdditlePrinters.Text))
            {
                error.AppendLine("Необходимо ввести Наименование принтера!");
            }
            foreach(Printers printers in Helper.GetIsSupportContext().Printers)
            {
                if (printers.Title.Equals(TxbAdditlePrinters.Text))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                error.AppendLine("Необходимо указать уникальное наименование принтера!");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (_contextPrinters.ID == 0)
            {
                if (nameImage == null)
                {
                    _contextPrinters.Image = null;
                }
                if (nameImage != null)
                {
                    _contextPrinters.Image=Helper.PrintersCopyImage(pathImage, nameImage);
                }
                Helper.GetIsSupportContext().Printers.Add(_contextPrinters);
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

        private void BtnPrintersCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
