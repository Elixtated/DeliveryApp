using CommonModule.CommonTools;
using DeliveryApp.MainWindow.Views;
using System;
using System.ComponentModel;
using System.Windows.Input;


namespace DeliveryApp.Login.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private const string User = "1";
        private const string Password = "1";
        private string _enterLogin;
        private string _enterPassword;
        
        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login,
                (o) =>
                {
                    if (string.IsNullOrEmpty(EnterLogin) && string.IsNullOrEmpty(EnterPassword))
                    {
                        return false;
                    }
                    
                    return true;
                });
        }

        public string EnterLogin
        {
            get => _enterLogin;
            set
            {
                _enterLogin = value;
                OnPropertyChanged("EnterLogin");
            }
        }
        
        public string EnterPassword
        {
            get => _enterPassword;
            set
            {
                _enterPassword = value;
                OnPropertyChanged("EnterPassword");
            }
        }

        public ICommand LoginCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        
        public Action CloseAction { get; set; }

        private void CloseCommandFunction()
        {
            CloseAction();
        }

        private void Login()
        {
            if (EnterLogin == User && EnterPassword == Password)
            {
                
                MainWindowView main = new MainWindowView();
                main.Show();
                CloseCommandFunction();
            }
        }
    }
}
