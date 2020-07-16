using DeliveryApp.Login.ViewModels;
using System;
using System.Windows;

namespace DeliveryApp.Login.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            DataContext = loginViewModel;
            loginViewModel.CloseAction = new Action(() => Close());
            InitializeComponent();
        }
    }
}
