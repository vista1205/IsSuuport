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
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }

        private void AutorizationButton_Click(object sender, RoutedEventArgs e)
        {
            Hash_helper hash_Helper = new Hash_helper();
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                errors.AppendLine("Вы не ввели логин!");
            }
            if (string.IsNullOrEmpty(PassordTextBox.Password))
            {
                errors.AppendLine("Вы не ввели пароль!");
            }
            if (!hash_Helper.CompareHash(PassordTextBox.Password) || !hash_Helper.LoginCorrect(LoginTextBox.Text))
            {
                errors.AppendLine("Вы ввели некорректно логин или пароль!");
            }
            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (hash_Helper.CompareHash(PassordTextBox.Password) && hash_Helper.LoginCorrect(LoginTextBox.Text))
            {
                hash_Helper.ReturnUser(PassordTextBox.Password);
                MainWindow mw = new MainWindow();
                mw.Show();
                Helper helper = new Helper();  
                helper.CloseWindow();
            }
        }
    }
}
