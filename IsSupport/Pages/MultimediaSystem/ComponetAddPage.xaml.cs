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
    /// Логика взаимодействия для ComponetAddPage.xaml
    /// </summary>
    public partial class ComponetAddPage : Page
    {
        Components _component = new Components();
        List<TypeComponent> typeComponents = new List<TypeComponent>();
        public ComponetAddPage(Components components)
        {
            InitializeComponent();
            if(components != null)
            {
                _component = components;
            }
            DataContext = _component;
            typeComponents = Helper.GetIsSupportContext().TypeComponent.ToList();
            CmbListTypeComponent.ItemsSource= typeComponents;
        }
        public ComponetAddPage()
        {
            InitializeComponent();
            DataContext = _component;
            typeComponents = Helper.GetIsSupportContext().TypeComponent.ToList();
            CmbListTypeComponent.ItemsSource = typeComponents;
        }

        private void BtnAddComponent_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error=new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbTitleComponent.Text))
            {
                error.AppendLine("Необходимо ввести наименование");
            }
            if (CmbListTypeComponent.SelectedItem == null)
            {
                error.AppendLine("Необходимо выбрать тип компонента");
            }
            if (string.IsNullOrWhiteSpace(TbDescription.Text))
            {
                error.AppendLine("Необходимо сделать описание");
            }
            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            if (_component.ID == 0)
            {
                var typeID = (CmbListTypeComponent.SelectedItem as TypeComponent).ID;
                _component.TypeComponentID = typeID;
                Helper.GetIsSupportContext().Components.Add(_component);
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
