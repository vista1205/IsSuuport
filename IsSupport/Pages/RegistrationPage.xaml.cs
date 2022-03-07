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

namespace IsSupport.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        private Employees _contextEmployess = new Employees();
        public RegistrationPage()
        {
            InitializeComponent();
            DataContext = _contextEmployess;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_contextEmployess.Surname))                
            {
                errors.AppendLine("Необходимо указать Фамилию");
            }

            if (string.IsNullOrWhiteSpace(_contextEmployess.Name))
            {
                errors.AppendLine("Необходимо указать Имя");
            }
                
            if (string.IsNullOrWhiteSpace(_contextEmployess.Patronymic))
            {
                errors.AppendLine("Необходимо указать отчество");
            }
                
            if (string.IsNullOrWhiteSpace(_contextEmployess.Login))
            {
                errors.AppendLine("Необходимо указать Логин");
            }
            if (PasswordText.Password.Length==0)
            { 
                errors.AppendLine("Необходимо ввести Пароль"); 
            }
            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_contextEmployess.ID == 0)
            {
                Hash_helper hash_Helper = new Hash_helper();
                _contextEmployess.Password = hash_Helper.CreateHash(PasswordText.Password);
                Helper.GetIsSupportContext().Employees.Add(_contextEmployess);
            }
            try
            {
                Helper.GetIsSupportContext().SaveChanges();
                MessageBox.Show("Вы зарегестрировались!");
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
