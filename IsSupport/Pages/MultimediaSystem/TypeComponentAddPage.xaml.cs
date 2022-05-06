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
    /// Логика взаимодействия для TypeComponentAddPage.xaml
    /// </summary>
    public partial class TypeComponentAddPage : Page
    {
        TypeComponent typeComponent = new TypeComponent();
        public TypeComponentAddPage(TypeComponent _typeComponent)
        {
            InitializeComponent();
            if(_typeComponent != null)
            {
                typeComponent = _typeComponent;
            }
            DataContext = typeComponent;
        }
        public TypeComponentAddPage()
        {
            InitializeComponent();
            DataContext = typeComponent;
        }

        private void BtnAddTypeComponent_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbTitleTypeComponet.Text))
            {
                error.AppendLine("Необходимо заполнить поле!");
            }
            var newTypeComponent=Helper.GetIsSupportContext().TypeComponent.FirstOrDefault(x=>x.Title==TbTitleTypeComponet.Text);
            if (newTypeComponent != null)
            {
                error.AppendLine("Необходимо указать уникальное значение!");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (typeComponent.ID == 0)
            {
                Helper.GetIsSupportContext().TypeComponent.Add(typeComponent);
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
