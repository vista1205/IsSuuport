using System;
using Microsoft.Win32;
using System.IO;
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
    /// Логика взаимодействия для AddKartridgPage.xaml
    /// </summary>
    public partial class AddKartridgPage : Page
    {
        private Kartridjs _cartridgContext = new Kartridjs();
        string pathImage = null;
        string nameImage = null;
        public AddKartridgPage()
        {
            InitializeComponent();
            CmbPrinterName.ItemsSource = Helper.GetIsSupportContext().Printers.ToList();
            DataContext = _cartridgContext;
        }

        private void BtnAddImageKartridg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory + @"\images\Kartridj\",
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

        private void BtnAddKartridg_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            StringBuilder erros=new StringBuilder();
            if (string.IsNullOrWhiteSpace(_cartridgContext.Title))
            {
                erros.AppendLine("Укажите наименование нового Картирджа");
            }
            if (string.IsNullOrWhiteSpace(_cartridgContext.NumberOfKartridj))
            {
                erros.AppendLine("Укажите номер нового Картриджа");
            }
            foreach(Kartridjs kartridjs in Helper.GetIsSupportContext().Kartridjs)
            {
                if (Equals(kartridjs.NumberOfKartridj, _cartridgContext.NumberOfKartridj))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                erros.AppendLine("Необходимо указать уникальный номер картриджа!");
            }
            if (_cartridgContext.Printers == null)
            {
                erros.AppendLine("Необходимо выбрать принтер!");
            }
            if(erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
                return;
            }
            if (_cartridgContext.ID == 0)
            {
                if (nameImage == null)
                {
                    _cartridgContext.Image = null;
                }
                if(nameImage != null)
                {
                    _cartridgContext.Image=Helper.KartridgCopyImage(pathImage, nameImage);
                }
                _cartridgContext.RoomID = 1;
                _cartridgContext.DatePay = DateTime.Now;
                _cartridgContext.StatusID = 1;
                Helper.GetIsSupportContext().Kartridjs.Add(_cartridgContext);

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

        private void BtnCancelKartridg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
