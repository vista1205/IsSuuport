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
    /// Логика взаимодействия для TypesEquipmentAddPage.xaml
    /// </summary>
    public partial class TypesEquipmentAddPage : Page
    {
        TypesEquipment _typesEquipment = new TypesEquipment();
        public TypesEquipmentAddPage(TypesEquipment typesEquipment)
        {
            if (typesEquipment != null)
            {
                _typesEquipment = typesEquipment;
            }
            InitializeComponent();
            DataContext = _typesEquipment;
        }
        public TypesEquipmentAddPage()
        {
            InitializeComponent();
            DataContext = _typesEquipment;
        }

        private void BtnAddTypesEquipment_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbTitleTypesEquipment.Text))
            {
                error.AppendLine("Необоходимо указать название типа оборудования");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (_typesEquipment.ID == 0)
            {
                var typeTitle = Helper.GetIsSupportContext().TypesEquipment.FirstOrDefault(x => x.Title == TbTitleTypesEquipment.Text);
                if (typeTitle != null)
                {
                    error.AppendLine("Необходимо указать уникальное гаименование типа оборудования");
                }
                if (error.Length > 0)
                {
                    MessageBox.Show(error.ToString());
                    return;
                }
                Helper.GetIsSupportContext().TypesEquipment.Add(_typesEquipment);
            }
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

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
