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
        public AddKartridgPage()
        {
            InitializeComponent();
            CmbPrinterName.ItemsSource = Helper.GetIsSupportContext().Printers.ToList();
        }

        private void BtnAddImageKartridg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string pathImage = null;
            string nameImage = null;
            if(ofd.ShowDialog() == true)
            {
                ofd.InitialDirectory = Environment.CurrentDirectory + "images\\Kartridj\\";
                ofd.Filter = "Image files (*.BMP, *.JPJ, *.JPEG)|*.bmp; *.jpj;*.jpeg";
                ofd.RestoreDirectory = true;
                nameImage = ofd.SafeFileName;
                pathImage = ofd.FileName.Replace(nameImage, "");
            }
                

            
        }
    }
}
